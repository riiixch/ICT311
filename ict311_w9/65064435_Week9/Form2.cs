using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _65064435_Week9
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            button1.Text = "คำนวณ";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text))
            {
                return;
            }

            int a = int.Parse(textBox1.Text);

            if (a < 0)
            {
                return;
            }

            String msg = "";

            for (int i = 1; i <= 12; i++)
            {
                msg += "" + a + " x " + i + " = " + (a * i) + "\n";
            }

            MessageBox.Show(msg);
        }
    }
}
