using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace Calculator
{
    public partial class Form1 : Form
    {
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
           (
               int nLeftRect,     // x-coordinate of upper-left corner
               int nTopRect,      // y-coordinate of upper-left corner
               int nRightRect,    // x-coordinate of lower-right corner
               int nBottomRect,   // y-coordinate of lower-right corner
               int nWidthEllipse, // height of ellipse
               int nHeightEllipse // width of ellipse
           );
        string first = "";
        string second = "";
        char function;
        double result = 0.0;
        string userImput = "";
        public Form1()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void guna2Button17_Click(object sender, EventArgs e)
        {
            function = '/';
            first = userImput;
            userImput = "";
        }

        private void guna2Button14_Click(object sender, EventArgs e)
        {
            function = '*';
            first = userImput;
            userImput = "";
        }

        private void guna2Button15_Click(object sender, EventArgs e)
        {
            function = '+';
            first = userImput;
            userImput = "";
        }

        private void guna2Button16_Click(object sender, EventArgs e)
        {
            function = '-';
            first = userImput;
            userImput = "";
        }

        private void guna2Button13_Click(object sender, EventArgs e)
        {
            second = userImput;
            double firstNum, secondNum;
            firstNum = Convert.ToDouble(first);
            secondNum = Convert.ToDouble(second);
            // adun
            if (function == '+')
            {
                result = firstNum + secondNum;
                calc_display.Text = result.ToString();
            }// scad
            else if (function == '-')
            {
                result = firstNum - secondNum;
                calc_display.Text = result.ToString();
            }// impart
            else if (function == '/')
            {
                if (secondNum == '0')
                {
                    calc_display.Text = "Error";
                }
                else
                {
                    result = firstNum / secondNum;
                    calc_display.Text = result.ToString();
                }
            } // inmultesc
            else if (function == '*')
            {
                result = firstNum * secondNum;
                calc_display.Text = result.ToString();
            }

        }

        private void guna2Button12_Click(object sender, EventArgs e)
        {
            function = '.';
            first = userImput;
            userImput = "";
        }

        private void calc_display_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button9_Click(object sender, EventArgs e)
        {
            calc_display.Text = "";
            userImput += "1";
            calc_display.Text += userImput;
        }

        private void guna2Button7_Click(object sender, EventArgs e)
        {
            calc_display.Text = "";
            userImput += "3";
            calc_display.Text += userImput;
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            calc_display.Text = "";
            userImput += "7";
            calc_display.Text += userImput;
        }

        private void num0_Click(object sender, EventArgs e)
        {
            calc_display.Text = "";
            userImput += "0";
            calc_display.Text += userImput;
        }

        private void num2_Click(object sender, EventArgs e)
        {
            calc_display.Text = "";
            userImput += "2";
            calc_display.Text += userImput;
        }

        private void num4_Click(object sender, EventArgs e)
        {
            calc_display.Text = "";
            userImput += "4";
            calc_display.Text += userImput;
        }

        private void num5_Click(object sender, EventArgs e)
        {
            calc_display.Text = "";
            userImput += "5";
            calc_display.Text += userImput;
        }

        private void num6_Click(object sender, EventArgs e)
        {
            calc_display.Text = "";
            userImput += "6";
            calc_display.Text += userImput;
        }

        private void num8_Click(object sender, EventArgs e)
        {
            calc_display.Text = "";
            userImput += "8";
            calc_display.Text += userImput;
        }

        private void num9_Click(object sender, EventArgs e)
        {
            calc_display.Text = "";
            userImput += "9";
            calc_display.Text += userImput;
        }

        private void clear_Click(object sender, EventArgs e)
        {
            first = "";
            second = "";
            userImput = "";
            result = 0.0;
            calc_display.Text = "0";
        }

        private void guna2CircleButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void guna2CircleButton2_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
    }
}
