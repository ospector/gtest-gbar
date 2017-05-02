using System.Drawing;
using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
namespace ColorProgressBar
{
    partial class ColorProgressBar
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

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;

            // Designer Error: in Visual Studio editor, 
            //   Generic.List cannot be called from InitializeComponent()
            //   move to it's own private method and call after InitializeComponent
            //   in ColorProgressBar.cs
            //progressColorList = new List<Color>();
        }

        #endregion

        int min = 0;	// Minimum value for progress range
        int max = 100;	// Maximum value for progress range
        int val = 0;    // Current progress
        //Color BarColor = Color.Blue;		// Color of progress meter
        //List<Color> progressColorList;    // moved to ColorProgressBar.cs InitializeListColor

        protected override void OnResize(EventArgs e)
        {
            // Invalidate the control to get a repaint.
            this.Invalidate();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            
            float percent = (float)(val - min) / (float)(max - min);
            Rectangle rect = this.ClientRectangle;
            // Calculate area for drawing the progress.
            int rectWidth = (int)((float)rect.Width * percent  / (val != 0 ? val : 1));

            Graphics g = e.Graphics;
            SolidBrush brush;
            LinearGradientBrush linGrBrush;

            int numberofcolors = progressColorList.Count;

            int countGreen = 0;
            int countRed = 0;
            int countGray = 0;

            List<Color>.Enumerator en = progressColorList.GetEnumerator();
            while (en.MoveNext())
            {
                Color currentColor = en.Current;
                if (currentColor.Equals(Color.Green))
                {
                    countGreen++;
                }
                if (currentColor.Equals(Color.Red))
                {
                    countRed++;
                }
                countGray++;
            }
            en.Dispose();
            countGray -=  countGreen + countRed;

            linGrBrush = new LinearGradientBrush(
                   new Point(0, 0),
                   new Point(0, 24),
                   Color.LightGreen,  
                   Color.Green); 


            //brush = new SolidBrush(Color.Green);
            
            rect.X = 0;
            rect.Width = rectWidth * countGreen;


            g.FillRectangle(linGrBrush, rect);
            linGrBrush = new LinearGradientBrush(
                   new Point(0, 0),
                   new Point(0, 24),
                   Color.Red,
                   Color.DarkRed);
            //brush = new SolidBrush(Color.Red);
            rect.X = rectWidth * countGreen;
            rect.Width = rectWidth * countRed;

            g.FillRectangle(linGrBrush, rect);

            linGrBrush = new LinearGradientBrush(
                   new Point(0, 0),
                   new Point(0, 24),
                   Color.LightGray,
                   Color.Gray);
            //brush = new SolidBrush(Color.Gray);
            rect.X = rectWidth * ( countGreen + countRed );
            rect.Width = rectWidth * countGray;
            g.FillRectangle(linGrBrush, rect);
            // Clean up.
            linGrBrush.Dispose();
            // Draw a three-dimensional border around the control.
            Draw3DBorder(g);

            
            g.Dispose();
        }

        public int Minimum
        {
            get
            {
                return min;
            }

            set
            {
                // Prevent a negative value.
                if (value < 0)
                {
                    min = 0;
                }

                // Make sure that the minimum value is never set higher than the maximum value.
                if (value > max)
                {
                    min = value;
                    min = value;
                }

                // Ensure value is still in range
                if (val < min)
                {
                    val = min;
                }

                // Invalidate the control to get a repaint.
                this.Invalidate();
            }
        }

        public int Maximum
        {
            get
            {
                return max;
            }

            set
            {
                // Make sure that the maximum value is never set lower than the minimum value.
                if (value < min)
                {
                    min = value;
                }

                max = value;

                // Make sure that value is still in range.
                if (val > max)
                {
                    val = max;
                }

                // Invalidate the control to get a repaint.
                this.Invalidate();
            }
        }

        public int Value
        {
            get
            {
                return val;
            }

            set
            {
                int oldValue = val;

                // Make sure that the value does not stray outside the valid range.
                if (value < min)
                {
                    val = min;
                }
                else if (value > max)
                {
                    val = max;
                }
                else
                {
                    val = value;
                }
                if (value == 0)
                {
                    progressColorList.Clear();
                }
                // Invalidate only the changed area.
                float percent;

                Rectangle newValueRect = this.ClientRectangle;
                Rectangle oldValueRect = this.ClientRectangle;

                // Use a new value to calculate the rectangle for progress.
                percent = (float)(val - min) / (float)(max - min);
                newValueRect.Width = (int)((float)newValueRect.Width * percent);

                // Use an old value to calculate the rectangle for progress.
                percent = (float)(oldValue - min) / (float)(max - min);
                oldValueRect.Width = (int)((float)oldValueRect.Width * percent);

                Rectangle updateRect = new Rectangle();

                // Find only the part of the screen that must be updated.
                if (newValueRect.Width > oldValueRect.Width)
                {
                    updateRect.X = oldValueRect.Size.Width;
                    updateRect.Width = newValueRect.Width - oldValueRect.Width;
                }
                else
                {
                    updateRect.X = newValueRect.Size.Width;
                    updateRect.Width = oldValueRect.Width - newValueRect.Width;
                }

                updateRect.Height = this.Height;

                // Invalidate the intersection region only.
                this.Invalidate(updateRect);
            }
        }

        public Color ProgressBarColor
        {
            get
            {
                return Color.Black; // BarColor;
            }

            set
            {
                //BarColor = value;
                progressColorList.Add(value);

                // Invalidate the control to get a repaint.
                this.Invalidate();
            }
        }

        private void Draw3DBorder(Graphics g)
        {
            int PenWidth = (int)Pens.White.Width;

            g.DrawLine(Pens.DarkGray,
                new Point(this.ClientRectangle.Left, this.ClientRectangle.Top),
                new Point(this.ClientRectangle.Width - PenWidth, this.ClientRectangle.Top));
            g.DrawLine(Pens.DarkGray,
                new Point(this.ClientRectangle.Left, this.ClientRectangle.Top),
                new Point(this.ClientRectangle.Left, this.ClientRectangle.Height - PenWidth));
            g.DrawLine(Pens.White,
                new Point(this.ClientRectangle.Left, this.ClientRectangle.Height - PenWidth),
                new Point(this.ClientRectangle.Width - PenWidth, this.ClientRectangle.Height - PenWidth));
            g.DrawLine(Pens.White,
                new Point(this.ClientRectangle.Width - PenWidth, this.ClientRectangle.Top),
                new Point(this.ClientRectangle.Width - PenWidth, this.ClientRectangle.Height - PenWidth));
        } 

    }
}
