﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cmpt291UI
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void CustomerLogIn_Click(object sender, EventArgs e)
        {
           WelcomeScreenCustomer form2 = new WelcomeScreenCustomer();
           form2.Show();
           this.Hide();
        }

        private void EmployeeLogIn_Click(object sender, EventArgs e)
        {
           LoginScreen LoginScreeenEmployee = new LoginScreen();
           LoginScreeenEmployee.Show();
           this.Hide();
        }
    }
}

