namespace Bella
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.GLVP_1 = new OpenTK.GLControl();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label_res_quad = new System.Windows.Forms.Label();
            this.label_res_lambda = new System.Windows.Forms.Label();
            this.trackBar_Q = new System.Windows.Forms.TrackBar();
            this.trackBar_L = new System.Windows.Forms.TrackBar();
            this.trackBar_LenQ = new System.Windows.Forms.TrackBar();
            this.label_LenQuad = new System.Windows.Forms.Label();
            this.label_Lambda = new System.Windows.Forms.Label();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_Q)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_L)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_LenQ)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.SuspendLayout();
            // 
            // GLVP_1
            // 
            this.GLVP_1.BackColor = System.Drawing.Color.Black;
            this.GLVP_1.Location = new System.Drawing.Point(0, 0);
            this.GLVP_1.Name = "GLVP_1";
            this.GLVP_1.Size = new System.Drawing.Size(561, 561);
            this.GLVP_1.TabIndex = 0;
            this.GLVP_1.VSync = false;
            this.GLVP_1.Paint += new System.Windows.Forms.PaintEventHandler(this.GLVP_1_Paint);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label_res_quad);
            this.groupBox1.Controls.Add(this.label_res_lambda);
            this.groupBox1.Controls.Add(this.trackBar_Q);
            this.groupBox1.Controls.Add(this.trackBar_L);
            this.groupBox1.Controls.Add(this.trackBar_LenQ);
            this.groupBox1.Controls.Add(this.label_LenQuad);
            this.groupBox1.Controls.Add(this.label_Lambda);
            this.groupBox1.Location = new System.Drawing.Point(567, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(405, 239);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Difraction";
            // 
            // label_res_quad
            // 
            this.label_res_quad.AutoSize = true;
            this.label_res_quad.Location = new System.Drawing.Point(105, 115);
            this.label_res_quad.Name = "label_res_quad";
            this.label_res_quad.Size = new System.Drawing.Size(44, 13);
            this.label_res_quad.TabIndex = 10;
            this.label_res_quad.Text = "1*0.1^1";
            // 
            // label_res_lambda
            // 
            this.label_res_lambda.AutoSize = true;
            this.label_res_lambda.Location = new System.Drawing.Point(21, 115);
            this.label_res_lambda.Name = "label_res_lambda";
            this.label_res_lambda.Size = new System.Drawing.Size(44, 13);
            this.label_res_lambda.TabIndex = 9;
            this.label_res_lambda.Text = "1*0.1^1";
            // 
            // trackBar_Q
            // 
            this.trackBar_Q.Location = new System.Drawing.Point(108, 188);
            this.trackBar_Q.Maximum = 25;
            this.trackBar_Q.Minimum = 1;
            this.trackBar_Q.Name = "trackBar_Q";
            this.trackBar_Q.Size = new System.Drawing.Size(291, 45);
            this.trackBar_Q.TabIndex = 8;
            this.trackBar_Q.Value = 1;
            this.trackBar_Q.Scroll += new System.EventHandler(this.trackBar_Q_Scroll);
            // 
            // trackBar_L
            // 
            this.trackBar_L.Location = new System.Drawing.Point(108, 34);
            this.trackBar_L.Maximum = 750;
            this.trackBar_L.Minimum = 250;
            this.trackBar_L.Name = "trackBar_L";
            this.trackBar_L.Size = new System.Drawing.Size(291, 45);
            this.trackBar_L.TabIndex = 7;
            this.trackBar_L.Value = 250;
            this.trackBar_L.Scroll += new System.EventHandler(this.trackBar_L_Scroll);
            // 
            // trackBar_LenQ
            // 
            this.trackBar_LenQ.Location = new System.Drawing.Point(108, 142);
            this.trackBar_LenQ.Maximum = 12;
            this.trackBar_LenQ.Name = "trackBar_LenQ";
            this.trackBar_LenQ.Size = new System.Drawing.Size(291, 45);
            this.trackBar_LenQ.TabIndex = 0;
            this.trackBar_LenQ.Scroll += new System.EventHandler(this.trackBar_LenQ_Scroll);
            // 
            // label_LenQuad
            // 
            this.label_LenQuad.AutoSize = true;
            this.label_LenQuad.Location = new System.Drawing.Point(6, 174);
            this.label_LenQuad.Name = "label_LenQuad";
            this.label_LenQuad.Size = new System.Drawing.Size(96, 13);
            this.label_LenQuad.TabIndex = 3;
            this.label_LenQuad.Text = "Длина квадрата: ";
            // 
            // label_Lambda
            // 
            this.label_Lambda.AutoSize = true;
            this.label_Lambda.Location = new System.Drawing.Point(6, 51);
            this.label_Lambda.Name = "label_Lambda";
            this.label_Lambda.Size = new System.Drawing.Size(50, 13);
            this.label_Lambda.TabIndex = 1;
            this.label_Lambda.Text = "Лямбда:";
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(576, 257);
            this.trackBar1.Maximum = 45;
            this.trackBar1.Minimum = 1;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(396, 45);
            this.trackBar1.TabIndex = 7;
            this.trackBar1.Value = 1;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 561);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.GLVP_1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Bella";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_Q)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_L)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_LenQ)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private OpenTK.GLControl GLVP_1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TrackBar trackBar_LenQ;
        private System.Windows.Forms.Label label_LenQuad;
        private System.Windows.Forms.Label label_Lambda;
        private System.Windows.Forms.Label label_res_lambda;
        private System.Windows.Forms.TrackBar trackBar_Q;
        private System.Windows.Forms.TrackBar trackBar_L;
        private System.Windows.Forms.Label label_res_quad;
        private System.Windows.Forms.TrackBar trackBar1;
    }
}

