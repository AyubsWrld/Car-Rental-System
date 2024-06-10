﻿namespace Cmpt291UI
{
    partial class WelcomeScreenCustomer
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
            this.button1 = new System.Windows.Forms.Button();
            this.Exit = new System.Windows.Forms.Button();
            this.Login = new System.Windows.Forms.Button();
            this.Clear = new System.Windows.Forms.Button();
            this.passwordBox = new System.Windows.Forms.TextBox();
            this.CustomerNumBox = new System.Windows.Forms.TextBox();
            this.PasswordLabel = new System.Windows.Forms.Label();
            this.employeeNumLabel = new System.Windows.Forms.Label();
            this.Welcome = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(96, 225);
            this.button1.Margin = new System.Windows.Forms.Padding(1);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(155, 29);
            this.button1.TabIndex = 17;
            this.button1.Text = "Sign Up";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Exit
            // 
            this.Exit.Location = new System.Drawing.Point(242, 272);
            this.Exit.Margin = new System.Windows.Forms.Padding(1);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(69, 25);
            this.Exit.TabIndex = 16;
            this.Exit.Text = "Exit";
            this.Exit.UseVisualStyleBackColor = true;
            // 
            // Login
            // 
            this.Login.Location = new System.Drawing.Point(182, 187);
            this.Login.Margin = new System.Windows.Forms.Padding(1);
            this.Login.Name = "Login";
            this.Login.Size = new System.Drawing.Size(69, 29);
            this.Login.TabIndex = 15;
            this.Login.Text = "Login";
            this.Login.UseVisualStyleBackColor = true;
            this.Login.Click += new System.EventHandler(this.Login_Click);
            // 
            // Clear
            // 
            this.Clear.Location = new System.Drawing.Point(96, 187);
            this.Clear.Margin = new System.Windows.Forms.Padding(1);
            this.Clear.Name = "Clear";
            this.Clear.Size = new System.Drawing.Size(69, 29);
            this.Clear.TabIndex = 14;
            this.Clear.Text = "Clear";
            this.Clear.UseVisualStyleBackColor = true;
            // 
            // passwordBox
            // 
            this.passwordBox.Location = new System.Drawing.Point(143, 138);
            this.passwordBox.Margin = new System.Windows.Forms.Padding(1);
            this.passwordBox.Name = "passwordBox";
            this.passwordBox.Size = new System.Drawing.Size(123, 20);
            this.passwordBox.TabIndex = 13;
            this.passwordBox.UseSystemPasswordChar = true;
            this.passwordBox.TextChanged += new System.EventHandler(this.passwordBox_TextChanged);
            // 
            // CustomerNumBox
            // 
            this.CustomerNumBox.Location = new System.Drawing.Point(143, 91);
            this.CustomerNumBox.Margin = new System.Windows.Forms.Padding(1);
            this.CustomerNumBox.Name = "CustomerNumBox";
            this.CustomerNumBox.Size = new System.Drawing.Size(123, 20);
            this.CustomerNumBox.TabIndex = 12;
            this.CustomerNumBox.TextChanged += new System.EventHandler(this.CustomerNumBox_TextChanged);
            // 
            // PasswordLabel
            // 
            this.PasswordLabel.AutoSize = true;
            this.PasswordLabel.Location = new System.Drawing.Point(54, 140);
            this.PasswordLabel.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.PasswordLabel.Name = "PasswordLabel";
            this.PasswordLabel.Size = new System.Drawing.Size(53, 13);
            this.PasswordLabel.TabIndex = 11;
            this.PasswordLabel.Text = "Password";
            // 
            // employeeNumLabel
            // 
            this.employeeNumLabel.AutoSize = true;
            this.employeeNumLabel.Location = new System.Drawing.Point(54, 94);
            this.employeeNumLabel.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.employeeNumLabel.Name = "employeeNumLabel";
            this.employeeNumLabel.Size = new System.Drawing.Size(65, 13);
            this.employeeNumLabel.TabIndex = 10;
            this.employeeNumLabel.Text = "Customer ID";
            // 
            // Welcome
            // 
            this.Welcome.AutoSize = true;
            this.Welcome.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.Welcome.Font = new System.Drawing.Font("Arial", 15.9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Welcome.Location = new System.Drawing.Point(125, 31);
            this.Welcome.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.Welcome.Name = "Welcome";
            this.Welcome.Size = new System.Drawing.Size(106, 26);
            this.Welcome.TabIndex = 9;
            this.Welcome.Text = "Welcome";
            // 
            // WelcomeScreenCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(338, 329);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.Login);
            this.Controls.Add(this.Clear);
            this.Controls.Add(this.passwordBox);
            this.Controls.Add(this.CustomerNumBox);
            this.Controls.Add(this.PasswordLabel);
            this.Controls.Add(this.employeeNumLabel);
            this.Controls.Add(this.Welcome);
            this.Name = "WelcomeScreenCustomer";
            this.Text = "WelcomeScreenCustomer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.Button Login;
        private System.Windows.Forms.Button Clear;
        private System.Windows.Forms.TextBox passwordBox;
        private System.Windows.Forms.TextBox CustomerNumBox;
        private System.Windows.Forms.Label PasswordLabel;
        private System.Windows.Forms.Label employeeNumLabel;
        private System.Windows.Forms.Label Welcome;
    }
}