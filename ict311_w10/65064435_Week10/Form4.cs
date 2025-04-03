using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _65064435_Week10
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            button1.Text = "#####";
            button2.Text = "00000";
            button3.Text = "00.00";
            button4.Text = "#0.##%";
            button5.Text = "(###)-###";
            button6.Text = "0.00";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(01234.ToString("#####"));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show(1234.ToString("00000"));
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show((1.1).ToString("00.00"));
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show((0.086).ToString("#0.##%"));
        }

        private void button5_Click(object sender, EventArgs e)
        {
            MessageBox.Show(123456789.ToString("(###)-###"));
        }

        private void button6_Click(object sender, EventArgs e)
        {
            MessageBox.Show(123456789.ToString("0.00"));
        }
    }
}
