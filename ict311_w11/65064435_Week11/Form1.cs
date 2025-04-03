using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _65064435_Week11
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label1.Text = "INPUT";

            button1.Text = "DATE TIME";
            button2.Text = "DATE";
            button3.Text = "Day of week";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = DateTime.Now.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = DateTime.Today.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = DateTime.Now.DayOfWeek.ToString();
        }
    }
}
