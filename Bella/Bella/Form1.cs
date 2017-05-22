using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using OpenTK.Graphics;
using System.Threading;
//using OpenTK.Platform.Windows;
//using OpenTK;

namespace Bella
{
    public partial class Form1 : Form
    {
        int x = 400;
        int y = 400;
        double[,] res = new double[500,500];
        // Degree - степень
        double Len_wave_Degree = 9, Len_quad_Degree = 1;
        int    Len_wave = 250;
        double Len_quad = 1;

        Difraction_ Difraction = new Difraction_();

        public Form1()
        {
            InitializeComponent();
        }

        private void __GlobalCoordinateAxis()
        {
            GL.PushMatrix();
            GL.Begin(BeginMode.Lines);
            GL.Color3(1.0, 0.0, 0.0);
            GL.Vertex3(0.0, 0.0, 0.0);
            GL.Vertex3(1.0, 0.0, 0.0);

            GL.Color3(0.0, 0.0, 1.0);
            GL.Vertex3(0.0, 0.0, 0.0);
            GL.Vertex3(0.0, 1.0, 0.0);

            GL.Color3(0.0, 1.0, 0.0);
            GL.Vertex3(0.0, 0.0, 0.0);
            GL.Vertex3(0.0, 0.0, 1.0);
            GL.End();
            GL.PopMatrix();
        }

        private void __Camera(double AngleRotationCamera_X, double AngleRotationCamera_Z)
        {
            OpenTK.Matrix4d anx, anz, proj, cam;
            anx = OpenTK.Matrix4d.RotateX(AngleRotationCamera_X * Math.PI / 180.0);
            anz = OpenTK.Matrix4d.RotateY(AngleRotationCamera_Z * Math.PI / 180.0);
            proj = OpenTK.Matrix4d.CreateOrthographic(10.0, 10.0, -10.0, 10.0);
            //cam = OpenTK.Matrix4d.LookAt(1.0, 1.0, -1.0,   0.0, 0.0, 0.0,   0.0, 1.0, 0.0);
            cam = OpenTK.Matrix4d.Mult(anz, anx);

            GL.LoadIdentity();
            GL.MatrixMode(MatrixMode.Projection);
            GL.LoadMatrix(ref proj);

            GL.MatrixMode(MatrixMode.Modelview);
            GL.LoadMatrix(ref cam);
        }

        private void GLVP_1_Paint(object sender, PaintEventArgs e)
        {
            GL.ClearColor(0.2f, 0.2f, 0.2f, 1.0f);
            GL.Clear(ClearBufferMask.ColorBufferBit | ClearBufferMask.DepthBufferBit);

            __Camera(0, 0);

            Difraction.Calc(x, y, ref res, Len_wave*Math.Pow(0.1, 9), Len_quad*Math.Pow(0.1,Len_quad_Degree));
            label_res_lambda.Text = Len_wave.ToString() + "*0.1^" + Len_wave_Degree.ToString();
            label_res_quad.Text   = Len_quad.ToString() + "*0.1^" + Len_quad_Degree.ToString();
            Difraction.DrawPlane(x, y, ref res, Len_wave);

            __GlobalCoordinateAxis();

            GL.Flush();

            GLVP_1.SwapBuffers();
            GLVP_1.Invalidate();

        }

        private void trackBar_LenQ_Scroll(object sender, EventArgs e)
        {
            Len_quad_Degree = (double)(trackBar_LenQ.Value);
        }

        private void trackBar_L_Scroll(object sender, EventArgs e)
        {
            Len_wave = trackBar_L.Value;
        }

        private void trackBar_Q_Scroll(object sender, EventArgs e)
        {
            Len_quad = trackBar_Q.Value;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            Difraction.angle = (double)30;
        }
    }
}
