﻿namespace MyCalculator
{
    partial class Form1
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            this.button14 = new System.Windows.Forms.Button();
            this.button15 = new System.Windows.Forms.Button();
            this.button16 = new System.Windows.Forms.Button();
            this.button17 = new System.Windows.Forms.Button();
            this.button18 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox1.Location = new System.Drawing.Point(23, 69);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(210, 74);
            this.textBox1.TabIndex = 0;
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(23, 158);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(42, 40);
            this.button1.TabIndex = 1;
            this.button1.Text = "7";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.myValue);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Gray;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button2.Location = new System.Drawing.Point(149, 158);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(42, 40);
            this.button2.TabIndex = 2;
            this.button2.Text = "/";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.myOperand);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(107, 158);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(42, 40);
            this.button3.TabIndex = 3;
            this.button3.Text = "9";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.myValue);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(65, 158);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(42, 40);
            this.button4.TabIndex = 4;
            this.button4.Text = "8";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.myValue);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(65, 198);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(42, 40);
            this.button5.TabIndex = 8;
            this.button5.Text = "5";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.myValue);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(107, 198);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(42, 40);
            this.button6.TabIndex = 7;
            this.button6.Text = "6";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.myValue);
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.Gray;
            this.button7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button7.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button7.Location = new System.Drawing.Point(149, 198);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(42, 40);
            this.button7.TabIndex = 6;
            this.button7.Text = "*";
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.myOperand);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(23, 198);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(42, 40);
            this.button8.TabIndex = 5;
            this.button8.Text = "4";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.myValue);
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(65, 238);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(42, 40);
            this.button9.TabIndex = 12;
            this.button9.Text = "2";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.myValue);
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(107, 238);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(42, 40);
            this.button10.TabIndex = 11;
            this.button10.Text = "3";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.myValue);
            // 
            // button11
            // 
            this.button11.BackColor = System.Drawing.Color.Gray;
            this.button11.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button11.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button11.Location = new System.Drawing.Point(149, 278);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(42, 40);
            this.button11.TabIndex = 10;
            this.button11.Text = "+";
            this.button11.UseVisualStyleBackColor = false;
            this.button11.Click += new System.EventHandler(this.myOperand);
            // 
            // button12
            // 
            this.button12.Location = new System.Drawing.Point(23, 238);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(42, 40);
            this.button12.TabIndex = 9;
            this.button12.Text = "1";
            this.button12.UseVisualStyleBackColor = true;
            this.button12.Click += new System.EventHandler(this.myValue);
            // 
            // button13
            // 
            this.button13.BackColor = System.Drawing.Color.Gray;
            this.button13.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button13.Location = new System.Drawing.Point(191, 238);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(42, 80);
            this.button13.TabIndex = 15;
            this.button13.Text = "=";
            this.button13.UseVisualStyleBackColor = false;
            this.button13.Click += new System.EventHandler(this.result);
            // 
            // button14
            // 
            this.button14.BackColor = System.Drawing.Color.Gray;
            this.button14.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button14.Location = new System.Drawing.Point(191, 198);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(42, 40);
            this.button14.TabIndex = 14;
            this.button14.Text = "C";
            this.button14.UseVisualStyleBackColor = false;
            this.button14.Click += new System.EventHandler(this.clear);
            // 
            // button15
            // 
            this.button15.BackColor = System.Drawing.Color.Gray;
            this.button15.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button15.Location = new System.Drawing.Point(191, 158);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(42, 40);
            this.button15.TabIndex = 13;
            this.button15.Text = "CE";
            this.button15.UseVisualStyleBackColor = false;
            this.button15.Click += new System.EventHandler(this.clear);
            // 
            // button16
            // 
            this.button16.Location = new System.Drawing.Point(23, 278);
            this.button16.Name = "button16";
            this.button16.Size = new System.Drawing.Size(84, 40);
            this.button16.TabIndex = 16;
            this.button16.Text = "0";
            this.button16.UseVisualStyleBackColor = true;
            this.button16.Click += new System.EventHandler(this.myValue);
            // 
            // button17
            // 
            this.button17.Location = new System.Drawing.Point(107, 278);
            this.button17.Name = "button17";
            this.button17.Size = new System.Drawing.Size(42, 40);
            this.button17.TabIndex = 18;
            this.button17.Text = ".";
            this.button17.UseVisualStyleBackColor = true;
            this.button17.Click += new System.EventHandler(this.myValue);
            // 
            // button18
            // 
            this.button18.BackColor = System.Drawing.Color.Gray;
            this.button18.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button18.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button18.Location = new System.Drawing.Point(149, 238);
            this.button18.Name = "button18";
            this.button18.Size = new System.Drawing.Size(42, 40);
            this.button18.TabIndex = 17;
            this.button18.Text = "-";
            this.button18.UseVisualStyleBackColor = false;
            this.button18.Click += new System.EventHandler(this.myOperand);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.button13);
            this.groupBox1.Controls.Add(this.button17);
            this.groupBox1.Controls.Add(this.button16);
            this.groupBox1.Controls.Add(this.button18);
            this.groupBox1.Controls.Add(this.button12);
            this.groupBox1.Controls.Add(this.button9);
            this.groupBox1.Controls.Add(this.button11);
            this.groupBox1.Controls.Add(this.button14);
            this.groupBox1.Controls.Add(this.button7);
            this.groupBox1.Controls.Add(this.button10);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.button15);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.button4);
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.button8);
            this.groupBox1.Controls.Add(this.button6);
            this.groupBox1.Controls.Add(this.button5);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(257, 354);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(198, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 19;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(283, 379);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.Button button15;
        private System.Windows.Forms.Button button16;
        private System.Windows.Forms.Button button17;
        private System.Windows.Forms.Button button18;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
    }
}

