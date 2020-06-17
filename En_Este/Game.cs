﻿using System;
using System.Windows.Forms;

namespace Arkanoid
{
    public partial class Game : Form
    {
        private int x = 10;
        private int t = 5;
        private int life = 5;
        private int score=00;
        private int ScoreMax = 18;

        public Game()
        {
            InitializeComponent();
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            ball.Top += x;
            ball.Left += t;
            label2.Text = "Score: " + score;
            label14.Text = "Life: " + life;

            if (ball.Bottom > ClientSize.Height)
            {
                x = -x;
            }

            if (ball.Top < 0)
            {
                x = -x;
            }
            
            if (ball.Right > ClientSize.Width)
            {
                t = -t;
            }
            
            if (ball.Left < 0)
            {
                t = -t;
            }

            if (ball.Bounds.IntersectsWith(mouse.Bounds))
            {
                x = -x;
            }
            
            foreach (Control s in Controls)
            {
                
                if (s is Label && (string)s.Tag == "block3")
                {
                    if (ball.Bounds.IntersectsWith(s.Bounds))
                    {
                        x = -x;
                        Controls.Remove(s);
                    }
                }
                
                if (s is Label && (string)s.Tag == "block")
                {
                    if (ball.Bounds.IntersectsWith(s.Bounds))
                    {
                        
                        score += 2;
                        x = -x;
                        Controls.Remove(s);
                        
                    }
                }
                if (s is Label && (string)s.Tag == "block2")
                {
                    if (ball.Bounds.IntersectsWith(s.Bounds))
                    {
                        score += 1;
                        x = -x;
                        Controls.Remove(s);
                    }
                }
                
                
            }
            
            if (ball.Bottom > ClientSize.Height || score == ScoreMax)
            {
                life--;
                if (life == 0)
                {
                    timer1.Stop();
                    MessageBox.Show("Tu record fue de: "+score);
                    
                    Conexion.ExecuteNonQuery($"insert into record(nombre_usuario, puntaje) values('{User.nombre}',{score})");
                    Close();
                }
            }
        }

        private void Game_MouseMove(object sender, MouseEventArgs e)
        {
            mouse.Left = e.X - mouse.Width / 2;
        }
    }
}