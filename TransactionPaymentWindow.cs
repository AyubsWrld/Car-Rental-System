using System;
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
    public partial class TransactionPaymentWindow : Form
    {
        public TransactionPaymentWindow()
        {
            InitializeComponent();
        }

        private void TransactionPaymentWindow_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

            DialogResult res;
            res = MessageBox.Show("Would you like to return to return to the previous menu? ", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (res == DialogResult.No)
            {
                Application.Exit();
            }
            else
            {
                this.Hide();
                CustomerWindow cusWindow = new CustomerWindow();        
                cusWindow.Show();   
            }
        }
    }
}
