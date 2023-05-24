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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            save fr1 = new save();
            fr1.ShowDialog();
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            del fr1 = new del();
            fr1.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Catalog fr1 = new Catalog();
            fr1.ShowDialog();   
        }
    }
}
