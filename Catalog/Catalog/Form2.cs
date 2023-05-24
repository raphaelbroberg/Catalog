using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Catalog
{
    public partial class save : Form
    {
        public save()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OleDbConnection conn = new OleDbConnection();
            conn.ConnectionString = "Provider = Microsoft.ace.oledb.12.0; Data Source = NYDB.accdb";
            conn.Open();

            OleDbCommand comm = new OleDbCommand();
            comm.CommandText = "INSERT INTO Tabell1(Namn, Skola, tre, brevlåda) VALUES ('"+txtName.Text+"', '"+txtClass.Text+"', '"+txtNumber.Text+"', '"+txtEmail.Text+"')";
            comm.Connection = conn;
            comm.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Number successfully saved");

        }
    }
}
