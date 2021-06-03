using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PiggyCatch
{
    public partial class Form1 : Form
    {
        private bool goleft, goright, space, pause;

        private int speed = 10;
        private int score = 0;
        private int missed = 0;

        private Random randX = new Random(); 
        private Random randY = new Random();

        public Form1()
        {
            InitializeComponent();
            Restart();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {

        }

        private void MainGamerTimerEvnt(object sender, EventArgs e)
        {
            txtScore.Text = "Score: " + score;
            txtMiss.Text = "Missed: " + missed;
           
            if (goleft == true && Player.Left > 0)
            {
                Player.Left -= 20;
            }

            if (goright == true && Player.Left + Player.Width < this.ClientSize.Width)
            {
                Player.Left += 20;
            }

            

            foreach (Control x in this.Controls)
            {
                if (x is PictureBox && (string) x.Tag == "Piggy")
                {
                    x.Top += speed;

                    if (x.Top + x.Height > this.ClientSize.Height)
                    {
                        x.Top = randY.Next(80, 300) * -1;
                        x.Left = randX.Next(5, this.ClientSize.Width - x.Width);

                        missed += 1;
                    }

                    if (Player.Bounds.IntersectsWith(x.Bounds))
                    {
                        x.Top = randY.Next(80, 1020) * -1;
                        x.Left = randX.Next(5, this.ClientSize.Width - x.Width);

                        Player.Image = Properties.Resources.ЕгорНям;
                        score += 1;
                    }

                }

                
            }

            if (score > 10)
            {
                speed += 1;
            }
            if (score > 20)
            {
                speed += 2;
            }
            if (score > 30)
            {
                speed += 3;
            }
            if (missed > 5)
            {
                GameTimer.Stop();
                MessageBox.Show("LOOOOOSER");
                Restart();
            }
        }
        private void KeyIsDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                goleft = true;
            }

            if (e.KeyCode == Keys.Right)
            {
                goright = true;
            }

            if (e.KeyCode == Keys.Pause)
            {
                pause = true;
                GameTimer.Stop();
            }
        }

        private void KeyIsUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                goleft = false;
            }

            if (e.KeyCode == Keys.Right)
            {
                goright = false;
            }

            if (e.KeyCode == Keys.Pause)
            {
                pause = true;
                GameTimer.Start();
            }
        }

        private void Restart()
        {
            foreach (Control x in this.Controls)
            {
                if (x is PictureBox && (string) x.Tag == "Piggy")
                {
                    x.Top = randY.Next(80, 300) * -1;
                    x.Left = randX.Next(5, this.ClientSize.Width - x.Width);
                }
            }

            Player.Left = this.ClientSize.Width / 2;
            Player.Image = Properties.Resources.Егор;

            score = 0;
            missed = 0;
            speed = 10;

            goleft = false;
            goright = false;

            GameTimer.Start();

        }
    }
}
