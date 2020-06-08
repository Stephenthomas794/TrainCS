using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Collections.Specialized;
using System.Diagnostics;
using System.Threading;
using System.Windows.Forms.DataVisualization.Charting;
using System.Timers;
using Windows.Gaming.Input;


namespace FormApp
{
    public partial class Form1 : Form
    {
        //////////////////////////////////////////////////////////////
        // Setup the display 
        System.Windows.Forms.Timer t = new System.Windows.Forms.Timer();
        public Form1()
        {
            InitializeComponent();
            SetTrainID(1007);
            SetSpeed(100);
            SetBarrier(75, 100);
            EnableMode1();
            SetProgressBarValue(83);
            EnableMode3();
            RadioTags(20);

            ///Draw();
            this.Load += Form1_Load_1;
            Gamepad.GamepadAdded += Gamepad_GamepadAdded;
            Gamepad.GamepadRemoved += Gamepad_GamepadRemovedAsync;

            t.Tick += T_Tick;
            t.Interval = 1000;
            t.Start();
        }

        //////////////////////////////////////////////////////////////
        // Set speed on main guage
        public void SetSpeed(int speed)
        {
            // set the modes manually
            SetGuageValue(speed);
        }

        //////////////////////////////////////////////////////////////
        ///Set Barrier 
        public void SetBarrier(int barrier, int speed)
        {
            SetBarrierValue(barrier, speed);
        }
        //////////////////////////////////////////////////////////////
        // Set each mode of the checkboxes by manually
        /* public void SetModes(bool mode1, bool mode2, bool mode3)
         {
             // set the modes manually
             SetGuageModes(mode1, mode2, mode3);
         }*/

        //////////////////////////////////////////////////////////////
        // Enabled the specified modes, disables the others
        //////////////////////////////////////////////////////////////
        public void EnableMode1()
        {
            SetGuageMode(1);
        }

        public void EnableMode2()
        {
            SetGuageMode(2);
        }

        public void EnableMode3()
        {
            SetGuageMode(3);
        }
        //////////////////////////////////////////////////////////////


        //////////////////////////////////////////////////////////////
        // Set Second Guage Value
        public void SetArrivals(int value)
        {

            SetArrivalsGuage(value);
        }

        //////////////////////////////////////////////////////////////
        // Set Progress Bar Value
        public void SetProgressBar(int value)
        {
            SetProgressBarValue(value);
        }

        /////////////////////////////////////////////////////////////
        ///Set Train ID
        public void SetTrainID(int Id)
        {
            SetTrainAs(Id);
        }



        ////////////////////////////////////////////////////////////////
        ///Braking Safety Drawing 
        ////////////////////////////////////////////////////////////////
        private void Form1_Load_1(object sender, EventArgs e)
        {
            btm = new Bitmap(580,580);
            g = Graphics.FromImage(btm);
            fG = CreateGraphics();
            th = new Thread(Draw);
            th.IsBackground = true;
            th.Start();

            // Connect the Paint event of the PictureBox to the event handler method.
            pictureBox2.Paint += new System.Windows.Forms.PaintEventHandler(pictureBox2_Paint);


        }

        private void SetDistanceTotal(int DistanceValueTotal)
        {
            //SetDistanceTotalValue(DistanceValueTotal);
        }

        private void pictureBox2_Paint(object sender, PaintEventArgs e)
        {
            SolidBrush SBRed = new SolidBrush(Color.Red);
            SolidBrush SBYellow = new SolidBrush(Color.Yellow);
            SolidBrush SBGreen = new SolidBrush(Color.Green);

            Rectangle Red = new Rectangle(0, 0, 62, 86);
            Rectangle Yellow = new Rectangle(0, 86, 62, 86);
            Rectangle Green = new Rectangle(0, 172, 62, 260);
            using (Pen pen = new Pen(Color.Red, 2))
            {
                e.Graphics.DrawRectangle(pen, Red);
                e.Graphics.FillRectangle(SBRed, Red);
            }

            using (Pen pen = new Pen(Color.Yellow, 2))
            {
                e.Graphics.DrawRectangle(pen, Yellow);
                e.Graphics.FillRectangle(SBYellow, Yellow);
            }

            using (Pen pen = new Pen(Color.Green, 2))
            {
                e.Graphics.DrawRectangle(pen, Green);
                e.Graphics.FillRectangle(SBGreen, Green);
            }
        }
        ////////////////////////////////////////////////////////////////
        
        ////////////////////////////////////////////////////////////////
        ///Refresh Button
        private void button1_Click(object sender, EventArgs e)
        {
            SetTrainID(1008);
            SetSpeed(50);
            SetBarrier(100, 50);
            EnableMode1();
            SetProgressBarValue(54);
            EnableMode1();
            Refresh();
        }

        ////////////////////////////////////////////////////////////////
        ///Triangle
        /////////////////////////////////////////////////////////////////
        Thread th;
        Graphics g;
        Graphics fG;
        Bitmap btm;

        bool drawing = true;
        public void Draw()
        {
            float angle = 0.0f;
            PointF org = new PointF(125, 220);
            float rad = 170;
            Pen pen = new Pen(Brushes.Azure, 3.0f);
            RectangleF area = new RectangleF(50, 50, 500, 500);
            RectangleF circle = new RectangleF(0, 0, 50, 50);

            PointF loc = PointF.Empty;
            PointF img = new PointF(20, 20);

            //fG.Clear(Color.Black);

           while (drawing)
            {
               // g.Clear(Color.Black);

                //g.DrawEllipse(pen, area);
                loc = CirclePoint(rad, angle, org);

                circle.X = loc.X - (circle.Width / 2) + area.X;
                circle.Y = loc.Y - (circle.Height / 2) + area.Y;

               // g.DrawEllipse(pen, circle);

               // fG.DrawImage(btm, img);

                if (angle < 360)
                {
                    angle += 0.5f;
                }
                else
                {
                    angle = 0;
                }
            }
        }

        private PointF  CirclePoint(float radius, float angleInDegrees, PointF origin)
        {
            float x = (float)(radius * Math.Cos(angleInDegrees * Math.PI / 180F) + origin.X);
            float y = (float)(radius * Math.Sin(angleInDegrees * Math.PI / 180F) + origin.Y);

            return new PointF(x, y);
        }

        public void SetTriangle()
        {

        }

        public void Calculate()
        {

        }

        /////////////////////////////////////////////////////////////////////

        /////////////////////////////////////////////////////////////////////
        ///Game Controller 
        //////////////////////////////////////////////////////////////////////
        Gamepad Controller;

        ///Game Controller - Removed/Added
        private async void Gamepad_GamepadRemovedAsync(object sender, Gamepad e)
        {
            await Log("Controller Removed");
        }

        private async void Gamepad_GamepadAdded(object sender, Gamepad e)
        {
            await Log("Controller Added");
        }

        private async Task Log(string txt)
        {
            Task t = Task.Run(() =>
            {
                Debug.WriteLine(DateTime.Now.ToShortTimeString() + ": " + txt);

            });
            await t;
        }
        
        private async void T_Tick(object sender,EventArgs e)
        {
            if(Gamepad.Gamepads.Count > 0)
            {
                Controller = Gamepad.Gamepads.First();
                var Reading = Controller.GetCurrentReading();
                switch (Reading.Buttons)
                {
                    case GamepadButtons.A:
                        await Log("A");
                        break;
                    case GamepadButtons.B:
                        await Log("B");
                        SetBreakXbox();
                        break;
                    case GamepadButtons.Y:
                        await Log("Y");
                        break;
                    case GamepadButtons.X:
                        await Log("X");
                        break;
                    case GamepadButtons.LeftShoulder:
                        await Log("Left Shoulder");
                        break;
                    case GamepadButtons.RightShoulder:
                        await Log("Right Shouler");
                        SetSpeedIncrease();
                        break;
                }
            }
        }
        ////////////////////////////////////////////////////////////////////
        
        ///////////////////////////////////////////////////////////////////
        ///Radio Tags
        
        public void RadioTags(int tagNumber)
        {
            SetRadioTags(tagNumber);
        }
    }
}
