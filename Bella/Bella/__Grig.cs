using System;
using System.Collections.Generic;
using System.Text;
using OpenTK.Graphics;

namespace Bella
{
    class Difraction_
    {
        public double angle = 1;

        OpenTK.Vector3 c = new OpenTK.Vector3();

        public void Calc(int X, int Y,ref double[,] res, double lenW, double lenQ)
        {
            int i, j;
            double A, B, C;
            double alpha, omega;

            for (i = -X/2; i < X/2; i += 1)
            {
                for (j = -Y/2; j < Y/2; j += 1)
                {
                    alpha = (i / angle) * 3.14 / 180.0;
                    omega = (j / angle) * 3.14 / 180.0;
                    A = (lenW * lenW) / (3.14 * 3.14 * lenQ * alpha * alpha * omega * omega * lenQ);
                    B = (3.14 * lenQ) / lenW;
                    C = Math.Sin(B * alpha) * Math.Sin(B * omega)*Math.Sin(B * omega) * Math.Sin(B * alpha);

                    if (i == 0 && j == 0)
                        res[i+X/2, j+Y/2] = 1;
                    else
                        res[i+X/2, j+Y/2] = A * C;
                }
            }
        }

        private OpenTK.Vector3 FromLenWaveToRGB(int LenWave)
        {
            const int R=680, G=520, B=430;
            
            if (LenWave>R)
            {
                c.X = 1.0f; c.Y = c.Z = 0; return c;
            }
            if (LenWave < B)
            {
                c.X = c.Y = 0; c.Z = 1.0f; return c;
            }
            if (LenWave < G)
            {
                c.X = (float)(255 * (LenWave - G) / (R - G));
                c.Y = (float)(255 * (R - LenWave) / (R - G));
                c.Z = 0;
                return c;
                //return RGB(255 * (LenWave - G) / (R - G), 255 * (R - LenWave) / (R - G), 0);
            }
            else
            {
                c.X = 0;
                c.Y = (float)(255 * (LenWave - B) / (G - B));
                c.Z = (float)(255 * (G - LenWave) / (G - B));
                return c;
                //return RGB(0, 255*(LenWave-B)/(G-B), 255*(G-LenWave)/(G-B));
            }
        }

        public void DrawPlane(int maxX, int maxY,ref double[,] res, int lenwave)
        {
            GL.PushMatrix();
            GL.Rotate(270.0, 1.0, 0.0, 0.0);
            GL.Translate(-1.5, 0.0, -1.5);
            GL.Begin(BeginMode.Points);
            for (int i = 0; i < maxX; i++)
                for (int j = 0; j < maxY; j++)
                {
                    GL.Color3(FromLenWaveToRGB(lenwave)*(float)res[i,j]);
                    GL.Vertex3(i * 0.01, 0, j * 0.01);
                }
            GL.End();
            GL.PopMatrix();
        }

       
    }
}
