using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculatorWinForm
{
    public partial class Form1 : Form
    {
        private double first = 0;
        private double second = 0;
        private char sign = ' ';
        public Form1()
        {
            InitializeComponent();
            ButtonCreate();
            Number.Text = "0";
            Result.Text = "0";
        }

        private void ButtonCreate()
        {
            System.Drawing.Drawing2D.GraphicsPath round = new System.Drawing.Drawing2D.GraphicsPath();
            round.AddEllipse(0, 0, 45, 45);
            Region region = new Region(round);

            foreach (var control in Digits.Controls)
            {
                if (control is Button button)
                {
                    button.Region = region;
                    button.BackgroundImageLayout = ImageLayout.Stretch;
                    button.Click += Digit_Click;
                }
            }
            foreach (var control in panel2.Controls)
            {
                if (control is Button button)
                {
                    button.Region = region;
                    button.BackgroundImageLayout = ImageLayout.Stretch;
                }
            }
            foreach (var control in Signs.Controls)
            {
                if (control is Button button)
                {
                    button.Region = region;
                    button.BackgroundImageLayout = ImageLayout.Stretch;

                }
            }
        }



        private void Digit_Click(object sender, EventArgs e)
        {
            if (sender is Button button)
                if (Number.Text == "0")
                {
                    Number.Text = button.TabIndex.ToString();
                }
                else
                {
                    Number.Text += button.TabIndex.ToString();
                }
        }
        private void Clean_Click(object sender, EventArgs e)
        {
            Number.Text = "0";
            Result.Text = "0";
            first = second = 0;
        }
        private void Zero_Click(object sender, EventArgs e)
        {
            if (Number.Text != "0")
                Number.Text += "0";
        }

        private void Point_Click(object sender, EventArgs e)
        {
            if (Number.Text == "" || Number.Text.Contains(','))
                return;
            Number.Text += ",";

        }


        #region Арифметические действия

        private void Plus_Click(object sender, EventArgs e)
        {
            first = double.Parse(Number.Text);
            sign = '+';

            Number.Text = "0";
        }

        private void Minus_Click(object sender, EventArgs e)
        {
            first = double.Parse(Number.Text);
            sign = '-';

            Number.Text = "0";
        }

        private void Mul_Click(object sender, EventArgs e)
        {
            first = double.Parse(Number.Text);
            sign = '*';

            Number.Text = "0";
        }

        private void Div_Click(object sender, EventArgs e)
        {
            first = double.Parse(Number.Text);
            sign = '/';

            Number.Text = "0";
        }

        private void Percent_Click(object sender, EventArgs e)
        {
            first = double.Parse(Number.Text);
            Result.Text = (first * 0.01).ToString();

            Number.Text = "0";
        }

        private void Equal_Click(object sender, EventArgs e)
        {
            second = second = double.Parse(Number.Text);
            switch (sign)
            {
                case '+': Result.Text = (first + second).ToString(); break;
                case '-': Result.Text = (first - second).ToString(); break;
                case '*': Result.Text = (first * second).ToString(); break;
                case '/': Result.Text = (first / second).ToString(); break;
            }
            Number.Text = "0";
            first = second = 0;
        }
        #endregion
    }
}
