﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.OleDb;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Catalog
{
    public partial class Catalog : Form
    {
        public Catalog()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OleDbConnection conn = new OleDbConnection();
            conn.ConnectionString = "Provider = Microsoft.ace.oledb.12.0; Data Source = NYDB.accdb";
            conn.Open();
            //MessageBox.Show("ok");

            OleDbCommand comm = new OleDbCommand();
            comm.CommandText = "select * from Tabell1";
            comm.Connection = conn;

            OleDbDataAdapter da = new OleDbDataAdapter();
            da.SelectCommand = comm;

            DataTable dt = new DataTable();
            da.Fill(dt);

            dataGridView1.DataSource = dt;


            conn.Close();
        }
    }
}
