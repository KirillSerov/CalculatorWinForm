namespace CalculatorWinForm
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Digits = new System.Windows.Forms.Panel();
            this.Num9 = new System.Windows.Forms.Button();
            this.Num3 = new System.Windows.Forms.Button();
            this.Num6 = new System.Windows.Forms.Button();
            this.Num8 = new System.Windows.Forms.Button();
            this.Num5 = new System.Windows.Forms.Button();
            this.Num7 = new System.Windows.Forms.Button();
            this.Num2 = new System.Windows.Forms.Button();
            this.Num4 = new System.Windows.Forms.Button();
            this.Num1 = new System.Windows.Forms.Button();
            this.Number = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Clean = new System.Windows.Forms.Button();
            this.Point = new System.Windows.Forms.Button();
            this.Zero = new System.Windows.Forms.Button();
            this.Percent = new System.Windows.Forms.Button();
            this.Signs = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.Div = new System.Windows.Forms.Button();
            this.Mul = new System.Windows.Forms.Button();
            this.Minus = new System.Windows.Forms.Button();
            this.Equal = new System.Windows.Forms.Button();
            this.Plus = new System.Windows.Forms.Button();
            this.Result = new System.Windows.Forms.TextBox();
            this.Digits.SuspendLayout();
            this.panel2.SuspendLayout();
            this.Signs.SuspendLayout();
            this.SuspendLayout();
            // 
            // Digits
            // 
            this.Digits.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Digits.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Digits.Controls.Add(this.Num9);
            this.Digits.Controls.Add(this.Num3);
            this.Digits.Controls.Add(this.Num6);
            this.Digits.Controls.Add(this.Num8);
            this.Digits.Controls.Add(this.Num5);
            this.Digits.Controls.Add(this.Num7);
            this.Digits.Controls.Add(this.Num2);
            this.Digits.Controls.Add(this.Num4);
            this.Digits.Controls.Add(this.Num1);
            this.Digits.Location = new System.Drawing.Point(12, 96);
            this.Digits.Margin = new System.Windows.Forms.Padding(5);
            this.Digits.Name = "Digits";
            this.Digits.Padding = new System.Windows.Forms.Padding(5);
            this.Digits.Size = new System.Drawing.Size(155, 155);
            this.Digits.TabIndex = 9;
            // 
            // Num9
            // 
            this.Num9.BackColor = System.Drawing.Color.LavenderBlush;
            this.Num9.BackgroundImage = global::CalculatorWinForm.Properties.Resources._9;
            this.Num9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Num9.FlatAppearance.BorderSize = 0;
            this.Num9.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.Num9.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.Num9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Num9.Location = new System.Drawing.Point(105, 5);
            this.Num9.Name = "Num9";
            this.Num9.Size = new System.Drawing.Size(45, 45);
            this.Num9.TabIndex = 9;
            this.Num9.UseVisualStyleBackColor = false;
            // 
            // Num3
            // 
            this.Num3.BackColor = System.Drawing.Color.LavenderBlush;
            this.Num3.BackgroundImage = global::CalculatorWinForm.Properties.Resources._3;
            this.Num3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Num3.FlatAppearance.BorderSize = 0;
            this.Num3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.Num3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.Num3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Num3.Location = new System.Drawing.Point(105, 105);
            this.Num3.Name = "Num3";
            this.Num3.Size = new System.Drawing.Size(45, 45);
            this.Num3.TabIndex = 3;
            this.Num3.UseVisualStyleBackColor = false;
            // 
            // Num6
            // 
            this.Num6.BackColor = System.Drawing.Color.LavenderBlush;
            this.Num6.BackgroundImage = global::CalculatorWinForm.Properties.Resources._6;
            this.Num6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Num6.FlatAppearance.BorderSize = 0;
            this.Num6.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.Num6.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.Num6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Num6.Location = new System.Drawing.Point(105, 55);
            this.Num6.Name = "Num6";
            this.Num6.Size = new System.Drawing.Size(45, 45);
            this.Num6.TabIndex = 6;
            this.Num6.UseVisualStyleBackColor = false;
            // 
            // Num8
            // 
            this.Num8.BackColor = System.Drawing.Color.LavenderBlush;
            this.Num8.BackgroundImage = global::CalculatorWinForm.Properties.Resources._8;
            this.Num8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Num8.FlatAppearance.BorderSize = 0;
            this.Num8.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.Num8.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.Num8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Num8.Location = new System.Drawing.Point(55, 5);
            this.Num8.Name = "Num8";
            this.Num8.Size = new System.Drawing.Size(45, 45);
            this.Num8.TabIndex = 8;
            this.Num8.UseVisualStyleBackColor = false;
            // 
            // Num5
            // 
            this.Num5.BackColor = System.Drawing.Color.LavenderBlush;
            this.Num5.BackgroundImage = global::CalculatorWinForm.Properties.Resources._5;
            this.Num5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Num5.FlatAppearance.BorderSize = 0;
            this.Num5.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.Num5.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.Num5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Num5.Location = new System.Drawing.Point(55, 55);
            this.Num5.Name = "Num5";
            this.Num5.Size = new System.Drawing.Size(45, 45);
            this.Num5.TabIndex = 5;
            this.Num5.UseVisualStyleBackColor = false;
            // 
            // Num7
            // 
            this.Num7.BackColor = System.Drawing.Color.LavenderBlush;
            this.Num7.BackgroundImage = global::CalculatorWinForm.Properties.Resources._7;
            this.Num7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Num7.FlatAppearance.BorderSize = 0;
            this.Num7.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.Num7.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.Num7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Num7.Location = new System.Drawing.Point(5, 5);
            this.Num7.Name = "Num7";
            this.Num7.Size = new System.Drawing.Size(45, 45);
            this.Num7.TabIndex = 7;
            this.Num7.UseVisualStyleBackColor = false;
            // 
            // Num2
            // 
            this.Num2.BackColor = System.Drawing.Color.LavenderBlush;
            this.Num2.BackgroundImage = global::CalculatorWinForm.Properties.Resources._2;
            this.Num2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Num2.FlatAppearance.BorderSize = 0;
            this.Num2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.Num2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.Num2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Num2.Location = new System.Drawing.Point(55, 105);
            this.Num2.Name = "Num2";
            this.Num2.Size = new System.Drawing.Size(45, 45);
            this.Num2.TabIndex = 2;
            this.Num2.UseVisualStyleBackColor = false;
            // 
            // Num4
            // 
            this.Num4.BackColor = System.Drawing.Color.LavenderBlush;
            this.Num4.BackgroundImage = global::CalculatorWinForm.Properties.Resources._4;
            this.Num4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Num4.FlatAppearance.BorderSize = 0;
            this.Num4.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.Num4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.Num4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Num4.Location = new System.Drawing.Point(5, 55);
            this.Num4.Name = "Num4";
            this.Num4.Size = new System.Drawing.Size(45, 45);
            this.Num4.TabIndex = 4;
            this.Num4.UseVisualStyleBackColor = false;
            // 
            // Num1
            // 
            this.Num1.BackColor = System.Drawing.Color.LavenderBlush;
            this.Num1.BackgroundImage = global::CalculatorWinForm.Properties.Resources._1;
            this.Num1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Num1.FlatAppearance.BorderSize = 0;
            this.Num1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.Num1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.Num1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Num1.Location = new System.Drawing.Point(5, 105);
            this.Num1.Name = "Num1";
            this.Num1.Size = new System.Drawing.Size(45, 45);
            this.Num1.TabIndex = 1;
            this.Num1.UseVisualStyleBackColor = false;
            // 
            // Number
            // 
            this.Number.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Number.Location = new System.Drawing.Point(14, 20);
            this.Number.Name = "Number";
            this.Number.ReadOnly = true;
            this.Number.Size = new System.Drawing.Size(268, 26);
            this.Number.TabIndex = 27;
            this.Number.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.Clean);
            this.panel2.Controls.Add(this.Point);
            this.panel2.Controls.Add(this.Zero);
            this.panel2.Location = new System.Drawing.Point(12, 254);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(155, 55);
            this.panel2.TabIndex = 28;
            // 
            // Clean
            // 
            this.Clean.BackColor = System.Drawing.Color.LavenderBlush;
            this.Clean.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Clean.FlatAppearance.BorderSize = 0;
            this.Clean.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.Clean.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.Clean.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Clean.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Clean.Location = new System.Drawing.Point(5, 5);
            this.Clean.Name = "Clean";
            this.Clean.Size = new System.Drawing.Size(45, 45);
            this.Clean.TabIndex = 35;
            this.Clean.Text = "C";
            this.Clean.UseVisualStyleBackColor = false;
            this.Clean.Click += new System.EventHandler(this.Clean_Click);
            // 
            // Point
            // 
            this.Point.BackColor = System.Drawing.Color.LavenderBlush;
            this.Point.BackgroundImage = global::CalculatorWinForm.Properties.Resources.point;
            this.Point.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Point.FlatAppearance.BorderSize = 0;
            this.Point.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.Point.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.Point.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Point.Location = new System.Drawing.Point(105, 5);
            this.Point.Name = "Point";
            this.Point.Size = new System.Drawing.Size(45, 45);
            this.Point.TabIndex = 30;
            this.Point.UseVisualStyleBackColor = false;
            this.Point.Click += new System.EventHandler(this.Point_Click);
            // 
            // Zero
            // 
            this.Zero.BackColor = System.Drawing.Color.LavenderBlush;
            this.Zero.BackgroundImage = global::CalculatorWinForm.Properties.Resources._0;
            this.Zero.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Zero.FlatAppearance.BorderSize = 0;
            this.Zero.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.Zero.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.Zero.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Zero.Location = new System.Drawing.Point(55, 5);
            this.Zero.Name = "Zero";
            this.Zero.Size = new System.Drawing.Size(45, 45);
            this.Zero.TabIndex = 0;
            this.Zero.UseVisualStyleBackColor = false;
            this.Zero.Click += new System.EventHandler(this.Zero_Click);
            // 
            // Percent
            // 
            this.Percent.BackColor = System.Drawing.Color.LavenderBlush;
            this.Percent.BackgroundImage = global::CalculatorWinForm.Properties.Resources.Percent;
            this.Percent.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Percent.FlatAppearance.BorderSize = 0;
            this.Percent.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.Percent.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.Percent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Percent.Location = new System.Drawing.Point(3, 105);
            this.Percent.Name = "Percent";
            this.Percent.Size = new System.Drawing.Size(45, 45);
            this.Percent.TabIndex = 35;
            this.Percent.Tag = "4";
            this.Percent.UseVisualStyleBackColor = false;
            this.Percent.Click += new System.EventHandler(this.Percent_Click);
            // 
            // Signs
            // 
            this.Signs.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Signs.Controls.Add(this.label1);
            this.Signs.Controls.Add(this.Div);
            this.Signs.Controls.Add(this.Percent);
            this.Signs.Controls.Add(this.Mul);
            this.Signs.Controls.Add(this.Minus);
            this.Signs.Controls.Add(this.Equal);
            this.Signs.Controls.Add(this.Plus);
            this.Signs.Location = new System.Drawing.Point(173, 96);
            this.Signs.Name = "Signs";
            this.Signs.Size = new System.Drawing.Size(105, 213);
            this.Signs.TabIndex = 29;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(19, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 30);
            this.label1.TabIndex = 10;
            this.label1.Text = "Casio";
            // 
            // Div
            // 
            this.Div.BackColor = System.Drawing.Color.LavenderBlush;
            this.Div.BackgroundImage = global::CalculatorWinForm.Properties.Resources.Div;
            this.Div.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Div.FlatAppearance.BorderSize = 0;
            this.Div.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.Div.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.Div.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Div.Location = new System.Drawing.Point(53, 105);
            this.Div.Name = "Div";
            this.Div.Size = new System.Drawing.Size(45, 45);
            this.Div.TabIndex = 34;
            this.Div.Tag = "3";
            this.Div.UseVisualStyleBackColor = false;
            this.Div.Click += new System.EventHandler(this.Div_Click);
            // 
            // Mul
            // 
            this.Mul.BackColor = System.Drawing.Color.LavenderBlush;
            this.Mul.BackgroundImage = global::CalculatorWinForm.Properties.Resources.Mul;
            this.Mul.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Mul.FlatAppearance.BorderSize = 0;
            this.Mul.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.Mul.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.Mul.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Mul.Location = new System.Drawing.Point(53, 55);
            this.Mul.Name = "Mul";
            this.Mul.Size = new System.Drawing.Size(45, 45);
            this.Mul.TabIndex = 33;
            this.Mul.Tag = "2";
            this.Mul.UseVisualStyleBackColor = false;
            this.Mul.Click += new System.EventHandler(this.Mul_Click);
            // 
            // Minus
            // 
            this.Minus.BackColor = System.Drawing.Color.LavenderBlush;
            this.Minus.BackgroundImage = global::CalculatorWinForm.Properties.Resources.Minus;
            this.Minus.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Minus.FlatAppearance.BorderSize = 0;
            this.Minus.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.Minus.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.Minus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Minus.Location = new System.Drawing.Point(3, 55);
            this.Minus.Name = "Minus";
            this.Minus.Size = new System.Drawing.Size(45, 45);
            this.Minus.TabIndex = 32;
            this.Minus.Tag = "1";
            this.Minus.UseVisualStyleBackColor = false;
            this.Minus.Click += new System.EventHandler(this.Minus_Click);
            // 
            // Equal
            // 
            this.Equal.BackColor = System.Drawing.Color.LavenderBlush;
            this.Equal.BackgroundImage = global::CalculatorWinForm.Properties.Resources.Equal;
            this.Equal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Equal.FlatAppearance.BorderSize = 0;
            this.Equal.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.Equal.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.Equal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Equal.Location = new System.Drawing.Point(53, 163);
            this.Equal.Name = "Equal";
            this.Equal.Size = new System.Drawing.Size(45, 45);
            this.Equal.TabIndex = 31;
            this.Equal.Tag = "5";
            this.Equal.UseVisualStyleBackColor = false;
            this.Equal.Click += new System.EventHandler(this.Equal_Click);
            // 
            // Plus
            // 
            this.Plus.BackColor = System.Drawing.Color.LavenderBlush;
            this.Plus.BackgroundImage = global::CalculatorWinForm.Properties.Resources.Plus;
            this.Plus.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Plus.FlatAppearance.BorderSize = 0;
            this.Plus.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.Plus.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.Plus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Plus.Location = new System.Drawing.Point(3, 163);
            this.Plus.Name = "Plus";
            this.Plus.Size = new System.Drawing.Size(45, 45);
            this.Plus.TabIndex = 30;
            this.Plus.Tag = "0";
            this.Plus.UseVisualStyleBackColor = false;
            this.Plus.Click += new System.EventHandler(this.Plus_Click);
            // 
            // Result
            // 
            this.Result.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Result.Location = new System.Drawing.Point(14, 52);
            this.Result.Name = "Result";
            this.Result.ReadOnly = true;
            this.Result.Size = new System.Drawing.Size(268, 26);
            this.Result.TabIndex = 30;
            this.Result.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Coral;
            this.ClientSize = new System.Drawing.Size(294, 321);
            this.Controls.Add(this.Result);
            this.Controls.Add(this.Signs);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.Number);
            this.Controls.Add(this.Digits);
            this.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Digits.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.Signs.ResumeLayout(false);
            this.Signs.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel Digits;
        private System.Windows.Forms.Button Num1;
        private System.Windows.Forms.Button Num9;
        private System.Windows.Forms.Button Num3;
        private System.Windows.Forms.Button Num6;
        private System.Windows.Forms.Button Num8;
        private System.Windows.Forms.Button Num5;
        private System.Windows.Forms.Button Num7;
        private System.Windows.Forms.Button Num2;
        private System.Windows.Forms.Button Num4;
        private System.Windows.Forms.TextBox Number;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button Percent;
        private System.Windows.Forms.Button Point;
        private System.Windows.Forms.Button Zero;
        private System.Windows.Forms.Panel Signs;
        private System.Windows.Forms.Button Div;
        private System.Windows.Forms.Button Mul;
        private System.Windows.Forms.Button Minus;
        private System.Windows.Forms.Button Equal;
        private System.Windows.Forms.Button Plus;
        private System.Windows.Forms.Button Clean;
        private System.Windows.Forms.TextBox Result;
        private System.Windows.Forms.Label label1;
    }
}
