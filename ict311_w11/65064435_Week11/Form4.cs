using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace _65064435_Week11
{
    public partial class Form4 : Form
    {
        OleDbConnection connect = new OleDbConnection();
        Class1 objA = new Class1();

        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            connect.ConnectionString = objA.strA;

            try
            {
                connect.Open();

                MessageBox.Show("Connection success");
            }
            catch
            {
                MessageBox.Show("Connection failed");
            }
        }
    }
}
