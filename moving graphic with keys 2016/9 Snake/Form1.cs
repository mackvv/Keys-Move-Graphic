using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace _9_Snake
{
    public partial class Form1 : Form
    {
        Rectangle rect = new Rectangle(0, 0, 20, 20);
        
        int x = 20;
        int y = 20;
        int xy = 0;
        int incret;

        int timertick;
        int colourChoice = 0;


        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            System.Drawing.Graphics graphics = this.CreateGraphics();
            timertick++;

            if (xy == 1)
            {
                x = x + incret;
            }

            else if (xy == 2)
            {
                y = y + incret;
            }

            DrawIt(x, y);
        }

        private void DrawIt(int x, int y)
        {
            
            System.Drawing.Graphics graphics = this.CreateGraphics();
            graphics.Clear(Color.Teal);

            rect.X = x;
            rect.Y = y;

            if (timertick % 100 == 0)
            {
                if (colourChoice == 0)
                {

                    colourChoice = 1; 
                } else if (colourChoice == 1)
                {

                    colourChoice = 2; 
                } else if (colourChoice == 2)
                { colourChoice = 3; }
                else if (colourChoice == 3)
                { colourChoice = 0; }

            }

            if (colourChoice == 0)
            {
                graphics.FillRectangle(new SolidBrush(Color.Red), rect);

            }
            else if (colourChoice == 1)
            {

                graphics.FillRectangle(new SolidBrush(Color.HotPink), rect);

            }
            else if (colourChoice == 2)
            {
                graphics.FillRectangle(new SolidBrush(Color.Blue), rect);

            }
            else if (colourChoice == 3)
            {
                graphics.FillRectangle(new SolidBrush(Color.Green), rect);

            }

            

            


            

        }

      

        private void Form1_KeyDown_1(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down)
            {


                incret = +5;
                xy = 2;


            }
            if (e.KeyCode == Keys.Up)
            {

                incret = -5;
                xy = 2;

            }
            if (e.KeyCode == Keys.Left)
            {


                incret = -5;
                xy = 1;

            }
            if (e.KeyCode == Keys.Right)
            {


                incret = +5;
                xy = 1;

            }

        }

       
    }
}
