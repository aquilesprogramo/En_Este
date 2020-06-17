using System.ComponentModel;

namespace Arkanoid
{
    partial class Game
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.mouse = new System.Windows.Forms.Label();
            this.ball = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Gold;
            this.label1.Location = new System.Drawing.Point(51, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 23);
            this.label1.TabIndex = 0;
            this.label1.Tag = "block";
            // 
            // mouse
            // 
            this.mouse.BackColor = System.Drawing.Color.Cornsilk;
            this.mouse.Location = new System.Drawing.Point(245, 340);
            this.mouse.Name = "mouse";
            this.mouse.Size = new System.Drawing.Size(152, 15);
            this.mouse.TabIndex = 1;
            // 
            // ball
            // 
            this.ball.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ball.Location = new System.Drawing.Point(303, 129);
            this.ball.Name = "ball";
            this.ball.Size = new System.Drawing.Size(13, 13);
            this.ball.TabIndex = 2;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(0, -1);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 26);
            this.label2.TabIndex = 3;
            this.label2.Text = "0";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Gold;
            this.label3.Location = new System.Drawing.Point(153, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 23);
            this.label3.TabIndex = 4;
            this.label3.Tag = "block";
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Gold;
            this.label4.Location = new System.Drawing.Point(245, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 23);
            this.label4.TabIndex = 5;
            this.label4.Tag = "block";
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.Gold;
            this.label5.Location = new System.Drawing.Point(348, 25);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 23);
            this.label5.TabIndex = 6;
            this.label5.Tag = "block";
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.Gold;
            this.label6.Location = new System.Drawing.Point(444, 25);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 23);
            this.label6.TabIndex = 7;
            this.label6.Tag = "block";
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.Gold;
            this.label7.Location = new System.Drawing.Point(538, 25);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(34, 23);
            this.label7.TabIndex = 8;
            this.label7.Tag = "block";
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.Red;
            this.label8.Location = new System.Drawing.Point(51, 82);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(34, 23);
            this.label8.TabIndex = 9;
            this.label8.Tag = "block2";
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.Color.Red;
            this.label9.Location = new System.Drawing.Point(153, 82);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(34, 23);
            this.label9.TabIndex = 10;
            this.label9.Tag = "block2";
            // 
            // label10
            // 
            this.label10.BackColor = System.Drawing.Color.Red;
            this.label10.Location = new System.Drawing.Point(245, 82);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(34, 23);
            this.label10.TabIndex = 11;
            this.label10.Tag = "block2";
            // 
            // label11
            // 
            this.label11.BackColor = System.Drawing.Color.Red;
            this.label11.Location = new System.Drawing.Point(348, 82);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(34, 23);
            this.label11.TabIndex = 12;
            this.label11.Tag = "block2";
            // 
            // label12
            // 
            this.label12.BackColor = System.Drawing.Color.Red;
            this.label12.Location = new System.Drawing.Point(444, 82);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(34, 23);
            this.label12.TabIndex = 13;
            this.label12.Tag = "block2";
            // 
            // label13
            // 
            this.label13.BackColor = System.Drawing.Color.Red;
            this.label13.Location = new System.Drawing.Point(538, 82);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(34, 23);
            this.label13.TabIndex = 14;
            this.label13.Tag = "block2";
            // 
            // label14
            // 
            this.label14.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label14.Location = new System.Drawing.Point(609, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(43, 26);
            this.label14.TabIndex = 15;
            this.label14.Text = "5";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label19
            // 
            this.label19.BackColor = System.Drawing.Color.Lime;
            this.label19.Location = new System.Drawing.Point(42, 25);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(50, 31);
            this.label19.TabIndex = 20;
            this.label19.Tag = "block3";
            // 
            // label15
            // 
            this.label15.BackColor = System.Drawing.Color.Lime;
            this.label15.Location = new System.Drawing.Point(143, 25);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(53, 31);
            this.label15.TabIndex = 21;
            this.label15.Tag = "block3";
            // 
            // label16
            // 
            this.label16.BackColor = System.Drawing.Color.Lime;
            this.label16.Location = new System.Drawing.Point(238, 25);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(50, 31);
            this.label16.TabIndex = 22;
            this.label16.Tag = "block3";
            // 
            // label17
            // 
            this.label17.BackColor = System.Drawing.Color.Lime;
            this.label17.Location = new System.Drawing.Point(342, 25);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(49, 31);
            this.label17.TabIndex = 23;
            this.label17.Tag = "block3";
            // 
            // label18
            // 
            this.label18.BackColor = System.Drawing.Color.Lime;
            this.label18.Location = new System.Drawing.Point(435, 25);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(52, 31);
            this.label18.TabIndex = 24;
            this.label18.Tag = "block3";
            // 
            // label20
            // 
            this.label20.BackColor = System.Drawing.Color.Lime;
            this.label20.Location = new System.Drawing.Point(531, 25);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(50, 31);
            this.label20.TabIndex = 25;
            this.label20.Tag = "block3";
            // 
            // Game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(647, 387);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ball);
            this.Controls.Add(this.mouse);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Game";
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Game_MouseMove);
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Label ball;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label mouse;
        private System.Windows.Forms.Timer timer1;

        #endregion
    }
}