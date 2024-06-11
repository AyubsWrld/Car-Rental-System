using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cmpt291UI
{
    public partial class WelcomeScreenCustomer : Form
    {
        public static string databasePath = "Data Source=LAPTOP-7KGL33RR;Initial Catalog=291;Integrated Security=True;Encrypt=False";
        public static string customerID;
        public WelcomeScreenCustomer()
        {
            InitializeComponent();
        }

        private void CustomerNumBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void Login_Click(object sender, EventArgs e)
        {

            String customerNum, user_password;

            customerNum= CustomerNumBox.Text;
            //employeeLoggedIn = employeeNumBox.Text;
            user_password = passwordBox.Text;

            try
            {
                SqlConnection conn = new SqlConnection(databasePath);
                String query = "SELECT * FROM Customers where CusID = '"+CustomerNumBox.Text+"' AND password = '"+ passwordBox.Text+"'";
                SqlDataAdapter sda = new SqlDataAdapter(query, conn);

                DataTable dtable = new DataTable();
                sda.Fill(dtable);

                if (dtable.Rows.Count > 0)
                {
                    customerID = CustomerNumBox.Text;
                    user_password = passwordBox.Text;

                    // page that needed to be loaded next
                    CustomerWindow form2 = new CustomerWindow();
                    form2.Show();
                    this.Hide();
                    conn.Dispose();
                    conn.Close();
                }
                else
                {
                    MessageBox.Show("Invalid login details", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    CustomerNumBox.Clear();
                    passwordBox.Clear();
                }
            }
            catch 
            {
                MessageBox.Show("Error");
            }
        }

        private void passwordBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
