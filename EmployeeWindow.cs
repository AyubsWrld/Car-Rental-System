﻿using System;
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
    public partial class EmployeeWindow : Form
    {
        public EmployeeWindow()
        {
            InitializeComponent();
        }
        public string databasePath = "Data Source=DESKTOP-SG96S0F;Initial Catalog=cmpt291;Integrated Security=True;Encrypt=False";
        private void Search(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void carsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // connect to database
            SqlConnection con = new SqlConnection(databasePath);
            con.Open();

            // search through database
            string query = "SELECT * FROM car";
            SqlDataAdapter adapter = new SqlDataAdapter(query, con);
            // insert data from extracted sql
            DataTable cars = new DataTable();
            adapter.Fill(cars);

            dataGridView1.DataSource = cars;

            con.Close();
        }

        private void carTypesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // connect to database
            SqlConnection con = new SqlConnection(databasePath);
            con.Open();

            // search through database
            string query = "SELECT * FROM cartypes";
            SqlDataAdapter adapter = new SqlDataAdapter(query, con);
            // insert data from extracted sql
            DataTable cartypes = new DataTable();
            adapter.Fill(cartypes);

            dataGridView1.DataSource = cartypes;

            con.Close();
        }

        private void customersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // connect to database
            SqlConnection con = new SqlConnection(databasePath);
            con.Open();

            // search through database
            string query = "SELECT * FROM customers";
            SqlDataAdapter adapter = new SqlDataAdapter(query, con);
            // insert data from extracted sql
            DataTable customers = new DataTable();
            adapter.Fill(customers);

            dataGridView1.DataSource = customers;

            con.Close();
        }

        private void employeesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // connect to database
            SqlConnection con = new SqlConnection(databasePath);
            con.Open();

            // search through database
            string query = "SELECT * FROM employees";
            SqlDataAdapter adapter = new SqlDataAdapter(query, con);
            // insert data from extracted sql
            DataTable employees = new DataTable();
            adapter.Fill(employees);

            dataGridView1.DataSource = employees;

            con.Close();
        }

        private void rentalTransactionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // connect to database
            SqlConnection con = new SqlConnection(databasePath);
            con.Open();

            // search through database
            string query = "SELECT * FROM rentaltransactions";
            SqlDataAdapter adapter = new SqlDataAdapter(query, con);
            // insert data from extracted sql
            DataTable rentaltransactions = new DataTable();
            adapter.Fill(rentaltransactions);

            dataGridView1.DataSource = rentaltransactions;

            con.Close();
        }

        private void runQueryToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void refreshToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}