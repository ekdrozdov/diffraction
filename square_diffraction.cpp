// source: Landsberg


#define _USE_MATH_DEFINES
#define NANO 9


#include <windows.h>
#include <stdlib.h>
#include <math.h>
#include <conio.h>
#include <cmath>
#include <fstream>
#include <ctime>



long double intensity(long double phi, long double psi, long double sourceintensity, long double waveLength,
	long double apertureWidth, long double apertureHigh) {

	long double squareSize = apertureWidth;

	long double firstPart = (sin(M_PI*apertureWidth*phi / waveLength)*sin(M_PI*apertureWidth*phi / waveLength)) / ((M_PI*apertureWidth*phi / waveLength)*(M_PI*apertureWidth*phi / waveLength));
	if (phi == 0)
		firstPart = 1;

	long double secondPart = (sin(M_PI*apertureHigh*psi / waveLength)*sin(M_PI*apertureHigh*psi / waveLength)) / ((M_PI*apertureHigh*psi / waveLength)*(M_PI*apertureHigh*psi / waveLength));
	if (psi == 0)
		secondPart = 1;

	return sourceintensity*firstPart*secondPart;
}


using namespace std;
void printInFile(long double* valuesArray, int arrayDimension) {
	ofstream file;
	file.open("output.txt");
	for (int i = 0; i < arrayDimension; i++) {
		file << valuesArray[i] << '\n';
	}
	file.close();
}


/*
COLORREF colorComputionByWavelengthAndintensity(long double waveLength, long double intensity) {
	float R = 0, G = 0, B = 0;

	if (waveLength >= 380 && waveLength < 440) {
		R = -(waveLength - 440) / (440 - 350);
		G = 0.0;
		B = 1.0;
	}
	else if (waveLength >= 440 && waveLength < 490) {
		R = 0.0;
		G = (waveLength - 440) / (490 - 440);
		B = 1.0;
	}
	else if (waveLength >= 490 && waveLength < 510) {
		R = 0.0;
		G = 1.0;
		B = -(waveLength - 510) / (510 - 490);
	}
	else if (waveLength >= 510 && waveLength < 580) {
		R = (waveLength - 510) / (580 - 510);
		G = 1.0;
		B = 0.0;
	}
	else if (waveLength >= 580 && waveLength < 645) {
		R = 1.0;
		G = -(waveLength - 645) / (645 - 580);
		B = 0.0;
	}
	else if (waveLength >= 645 && waveLength <= 780) {
		R = 1.0;
		G = 0.0;
		B = 0.0;
	}
	else {
		R = 0.0;
		G = 0.0;
		B = 0.0;
	}

	return RGB(R, G, B);
}
*/


COLORREF getColor(long double waveLength, long double intensity) {
	int red = 0, green = 0, blue = 0;
	if ((waveLength > 560) && (waveLength <= 760))  red = 255;
	if ((waveLength > 495) && (waveLength <= 555))  red = 0;
	if ((waveLength > 570) && (waveLength <= 580))  red = (int)(127.5 + 127.5*(waveLength - 570) / 10);
	if ((waveLength > 555) && (waveLength <= 570))  red = (int)(127.5*(waveLength - 555) / 15);
	if ((waveLength > 480) && (waveLength <= 495))  red = (int)(127.5 - 127.5*(waveLength - 480) / 15);
	if ((waveLength > 380) && (waveLength <= 480))  red = (int)(255 - 127.5*(waveLength - 380) / 100);

	if ((waveLength > 380) && (waveLength <= 525))  blue = 255;
	if ((waveLength > 555) && (waveLength <= 760))  blue = 0;
	if ((waveLength > 540) && (waveLength <= 555))  blue = (int)(127.5 - 127.5*(waveLength - 540) / 15);
	if ((waveLength > 525) && (waveLength <= 540))  blue = (int)(255 - 127.5*(waveLength - 525) / 15);

	if ((waveLength > 525) && (waveLength <= 580))  green = 255;
	if ((waveLength > 380) && (waveLength <= 495))  green = 0;
	if ((waveLength > 610) && (waveLength <= 760))  green = (int)(63.5 - 63.5*(waveLength - 610) / 150);
	if ((waveLength > 600) && (waveLength <= 610))  green = (int)(127.5 - 63.5*(waveLength - 600) / 10);
	if ((waveLength > 590) && (waveLength <= 600))  green = (int)(190.5 - 63.5*(waveLength - 590) / 10);
	if ((waveLength > 580) && (waveLength <= 590))  green = (int)(255 - 63.5*(waveLength - 580) / 10);
	if ((waveLength > 495) && (waveLength <= 510))  green = (int)(127.5*(waveLength - 495) / 15);
	if ((waveLength > 510) && (waveLength <= 525))  green = (int)(127.5 + 127.5*(waveLength - 510) / 15);

	return RGB(red*intensity, green*intensity, blue*intensity);
}



int main(void)
{
	// --- INITIALAZE ---
	clock_t  timer;
	int totalComputing = 0, totalDraw = 0, totalTime = 0;
	timer = clock();

	ofstream file;
	file.open("output.txt");

	HDC hDC = GetDC(GetConsoleWindow());
	HPEN Pen = CreatePen(PS_SOLID, 2, RGB(255, 255, 255));
	SelectObject(hDC, Pen);


	long double waveLength = 460.0e-9;
	int waveLength_NM = 460;
	long double sourceintensity = 100;
	long double apertureWidth = 200.0e-8;
	long double apertureHigh = 200.0e-8;
	long double resultintensity = 0;
	int i = 0, j = 0;
	long double phi = 0.0, psi = 0.0;
	int nodesCount = 400;
	// ---

	timer = clock() - timer;
	totalTime += timer;

	for (int i = 0; i < nodesCount; i++) {
		phi = M_PI * i / nodesCount;
		for (int j = 0; j < nodesCount; j++) {
			psi = M_PI * j / nodesCount;
			timer = clock();
			resultintensity = intensity(phi - M_PI / 2, psi - M_PI / 2, sourceintensity, waveLength, apertureWidth, apertureHigh);
			timer = clock() - timer;
			totalComputing += timer;
			totalTime += timer;

			timer = clock();
			SetPixel(hDC, i, j, getColor(waveLength_NM, resultintensity));
			timer = clock() - timer;
			totalDraw += timer;
			totalTime += timer;
			//SetPixel(hDC, i, j, colorComputionByWavelengthAndintensity(waveLenghtInNM, resultintensity));
		}
	}
	file << "Time for computing: " << totalComputing << '\n';
	file << "Time for drawing: " << totalDraw << '\n';
	file << "Total time: " << totalTime << '\n';
	file.close();

	_getch();

	return 0;
}
