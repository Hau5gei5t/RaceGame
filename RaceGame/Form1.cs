using System;
using System.Drawing;
using System.Windows.Forms;

namespace RaceGame
{
    public partial class Form1 : Form
    {
        private int carSpeed = 5;
        private int roadSpeed = 5;
        private int trafficSpeed = 5;
        private int Score = 0;
        private bool carLeft;
        private bool carRight;
        private Random rnd = new Random();

        private void Reset()
        {
            Trophy.Visible = false;
            button1.Enabled = false;
            Explosion.Visible = false;
            
            trafficSpeed = 5;
            roadSpeed = 5;
            Score = 0;
            
            Player.Left = 161; 
            Player.Top = 286;
            
            carLeft = false; 
            carRight = false;
            
            AI1.Left = 66;
            AI1.Top = -120;

            AI2.Left = 294;
            AI2.Top = -185;

            RoadTrack2.Left = 0;
            RoadTrack2.Top = 0;
            RoadTrack1.Left = 0;
            RoadTrack1.Top = -632;

            timer1.Start();
        }

        public Form1()
        {
            InitializeComponent();
            Reset();
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            Score++;
            Distance.Text = "" + Score;
            RoadTrack1.Top += roadSpeed; 
            RoadTrack2.Top += roadSpeed;
            if (RoadTrack1.Top > 630)
            {
                RoadTrack1.Top = -630;
            }
            if (RoadTrack2.Top > 630)
            {
                RoadTrack2.Top = -630;
            }
            if (carLeft) { Player.Left -= carSpeed; }
            if (carRight) { Player.Left += carSpeed; }

            if (Player.Left < 1)
            {
                carLeft = false;
            }
            else if (Player.Left + Player.Width > 380)
            {
                carRight = false;
            }

            AI1.Top += trafficSpeed;
            AI2.Top += trafficSpeed;

            if (AI1.Top > panel1.Height)
            {
                ChangeAI1(); AI1.Left = rnd.Next(2, 160); AI1.Top = rnd.Next(100, 200) * -1;
            }

            if (AI2.Top > panel1.Height)
            {
                ChangeAI2(); AI2.Left = rnd.Next(185, 327); AI2.Top = rnd.Next(100, 200) * -1;
            }

            if (Player.Bounds.IntersectsWith(AI1.Bounds) || Player.Bounds.IntersectsWith(AI2.Bounds))
            {
                GameOver();
            }

            if (Score > 100 && Score < 500)
            {
                trafficSpeed = 6;
                roadSpeed = 7;
            }
            else if (Score > 500 && Score < 1000)
            {
                trafficSpeed = 7;
                roadSpeed = 8;
            }
            else if (Score > 1200)
            {
                trafficSpeed = 9;
                roadSpeed = 10;
            }
        }

        private void MoveCar(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left && Player.Left > 0)
            {
                carLeft = true;
            }
            if (e.KeyCode == Keys.Right && Player.Left + Player.Width < panel1.Width)
            {
                carRight = true;
            }
        }

        private void StopCar(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                carLeft = false;
            }
            if (e.KeyCode == Keys.Right)
            {
                carRight = false;
            }
        }

        private void ChangeAI1()
        {
            int num = rnd.Next(1, 8);
            switch (num)
            {
                case 1:
                    AI1.Image = Properties.Resources.carGreen;
                    break;
                case 2:
                    AI1.Image = Properties.Resources.carGrey;
                    break;
                case 3:
                    AI1.Image = Properties.Resources.carYellow;
                    break;
                case 4:
                    AI1.Image = Properties.Resources.carPink;
                    break;
                case 5:
                    AI1.Image = Properties.Resources.CarRed;
                    break;
                case 6:
                    AI1.Image = Properties.Resources.TruckBlue;
                    break;
                case 7:
                    AI1.Image = Properties.Resources.TruckWhite;
                    break;
                case 8:
                    AI1.Image = Properties.Resources.ambulance;
                    break;

                default:
                    break;
            }
        }

        private void ChangeAI2()
        {
            int num = rnd.Next(1, 8); switch (num)
            {
                case 1:
                    AI1.Image = Properties.Resources.carGreen;
                    break;
                case 2:
                    AI1.Image = Properties.Resources.carGrey;
                    break;
                case 3:
                    AI1.Image = Properties.Resources.carYellow;
                    break;
                case 4:
                    AI1.Image = Properties.Resources.carPink;
                    break;
                case 5:
                    AI1.Image = Properties.Resources.CarRed;
                    break;
                case 6:
                    AI1.Image = Properties.Resources.TruckBlue;
                    break;
                case 7:
                    AI1.Image = Properties.Resources.TruckWhite;
                    break;
                case 8:
                    AI1.Image = Properties.Resources.ambulance;
                    break;

                default:
                    break;
            }
        }

        private void GameOver()
        {
            Trophy.Visible = true;
            timer1.Stop();
            button1.Enabled = true;
            Explosion.Visible = true; Player.Controls.Add(Explosion); Explosion.Location = new Point(-8, 5); Explosion.BackColor = Color.Transparent; Explosion.BringToFront();

            if (Score < 1000)
            {
                Trophy.Image = Properties.Resources.bronze;
            }
            if (Score > 2000)
            {
                Trophy.Image = Properties.Resources.silver;
            }

            if (Score > 3500)
            {
                Trophy.Image = Properties.Resources.gold;
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Reset();
        }
    }
}