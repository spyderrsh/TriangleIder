using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TriangleIDer
{
    public partial class MainForm : Form
    {
        private const double _EPSILON = .00000001;
        double a = 0;
        double b = 0;
        double c = 0;

        private bool validTriangleAvailable = false;
        public MainForm()
        {
            InitializeComponent();
        }

        public static double EPSILON => _EPSILON;

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void sideTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBox textbox = ((sender) as TextBox);

            //Don't Allow any characters except Control Characters, Digits, and '.'
            if(!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            //Only allow one '.'
            if((e.KeyChar =='.') && textbox.Text.IndexOf('.') > -1)
            {
                e.Handled = true;
            }
            
            //TODO Handle Paste
        }

        private void TB_Side_TextChanged(object sender, EventArgs e)
        {
            TextBox textbox = sender as TextBox;
            double value;
            StatusLabel.Text = "Please Input Numeric Values > 0 Into Sides A, B, and C";
            validTriangleAvailable = false;
            TriangleViewPanel.Invalidate();
            //Validate and if successful, change value
            if (!ValidateNumber(textbox, out value))
                return;

            //Assign value to corresponding triangle
            if (sender == TB_SideA)
                a = value;
            if (sender == TB_SideB)
                b = value;
            if (sender == TB_SideC)
                c = value;

            //Check That they are all Non-Zero
            if (!(a * b * c > 0))
                return;

            //Possible Triangle... Start Checks
            //sort into an array for less checks
            double[] sides = new double[3] { a, b, c };
            Array.Sort(sides);
            //SQRD array for multiple checks
            double[] sides_sqrd = new double[3] { sides[0] * sides[0], sides[1] * sides[1], sides[2] * sides[2] };

            //Check invalid triangle
            if (sides[0] + sides[1] <= sides[2])
            {
                StatusLabel.Text = "Those lengths do not form a Triangle.";
                return;
            }
            validTriangleAvailable = true;
            TriangleViewPanel.Invalidate();
            StatusLabel.Text = "Those lengths form a Triangle.";
            if (RightTriangleCheck_PreSQRD(sides_sqrd))
                StatusLabel.Text = "Those lengths form a Right Triangle";
            if(sides[0] == sides[1] || sides[1]== sides[2] || sides[0]==sides[2])
            {
                if (sides[0] == sides[1] && sides[1] == sides[2])
                    StatusLabel.Text = "Those lengths form an Equilateral Triangle";
                else if (RightTriangleCheck_PreSQRD(sides_sqrd))
                    StatusLabel.Text = "Those lengths form a Right Isosceles Triangle";
                else
                    StatusLabel.Text = "Those lengths form an Isosceles Triangle.";

            }

        }

        private bool RightTriangleCheck_PreSQRD(double[] sides_sqrd)
        {
            return Math.Abs(sides_sqrd[0] + sides_sqrd[1] - sides_sqrd[2]) < EPSILON;
        }

        private bool ValidateNumber(TextBox textbox, out double value)
        {
            value = 0;
            string text = textbox.Text;
            if (text.Length == 0)
                return false;
            bool periodSet = false;

            //Check each character for valid input
            foreach (char c in text)
            {
                if (!(char.IsNumber(c) || (c == '.' && !periodSet)))
                    //TODO Show ToolTip
                    return false;
                if (c == '.')
                    periodSet = true;
            }

            value = Double.Parse(text);
            return true;
        }

        private void TriangleViewPanel_Paint(object sender, PaintEventArgs e)
        {
            if (!validTriangleAvailable)
                return;

            double width = TriangleViewPanel.Width-2;
            double height = TriangleViewPanel.Height-2;

            double Ax = 0;
            double Ay = 0;
            
            double Bx = a;
            double By = 0;

            //Calculate Cx Cy using law of cosines 
            //C_theta = arccos((c^2 - a^2 - b^2)/(2ab)
            double C_theta = Math.Acos((a * a + c * c - b * b) / (2 * a * c));
            double Cx = Math.Cos(C_theta) * c;
            double Cy = Math.Sin(C_theta) * c;

            //Scale Triangle to fit inside the Panel
            double MaxX = a;
            if (Cx > MaxX)
                MaxX = Cx;
            if(Cx < 0)
            {
                MaxX = a - Cx;

                //Shift right
                Ax -= Cx;
                Bx -= Cx;
                Cx = 0;
            }
            //Compare porportions
            double ScaleFactor = width / MaxX;
            double yScaleFactor = height / Cy;
            if(MaxX < width || Cy < height)
            {
                //Scale Down
                ScaleFactor = (ScaleFactor < yScaleFactor) ? ScaleFactor : yScaleFactor;
            } else
            {
                //Scale Up
                ScaleFactor = (ScaleFactor > yScaleFactor) ? ScaleFactor : yScaleFactor;
            }

            Ax *= ScaleFactor;
            Bx *= ScaleFactor;
            Cx *= ScaleFactor;
            Cy *= ScaleFactor;

            //Center
            Ay = (height - Cy) / 2.0;
            By += Ay;
            Cy += Ay;

            MaxX *= ScaleFactor;
            double xShift = (width - MaxX) / 2.0;

            Ax += xShift;
            Bx += xShift;
            Cx += xShift;


            Point ptA = new Point((int)Ax+1,1);
            Point ptB = new Point((int)Bx+1, 1);
            Point ptC = new Point((int)Cx+1, (int)Cy);

            //Draw
            Pen p = new Pen(Color.CornflowerBlue, 2);
            e.Graphics.DrawLine(p, ptA, ptB);
            e.Graphics.DrawLine(p, ptB, ptC);
            e.Graphics.DrawLine(p, ptA, ptC);
        }

        private bool IsValidTriangle(double[] sortedSides)
        {
            //Check invalid triangle
            if (sortedSides[0] + sortedSides[1] <= sortedSides[2])
            {
                return false;
            }
            return true;
        }
    }
}
