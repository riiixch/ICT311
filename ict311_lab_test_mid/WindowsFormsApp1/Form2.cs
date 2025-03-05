using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            label1.Text = "ตัวเลขที่ 1";
            label2.Text = "ตัวเลขที่ 2";
            label3.Text = "คำตอบ";

            textBox3.ReadOnly = true;

            button1.Text = "+";
            button2.Text = "-";
            button3.Text = "*";
            button4.Text = "/";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text) || string.IsNullOrWhiteSpace(textBox2.Text))
            {
                return;
            }

            double a = double.Parse(textBox1.Text);
            double b = double.Parse(textBox2.Text);

            double res = a + b;

            textBox3.Text = res.ToString("0.000");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text) || string.IsNullOrWhiteSpace(textBox2.Text))
            {
                return;
            }

            double a = double.Parse(textBox1.Text);
            double b = double.Parse(textBox2.Text);

            double res = a - b;

            textBox3.Text = res.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text) || string.IsNullOrWhiteSpace(textBox2.Text))
            {
                return;
            }

            double a = double.Parse(textBox1.Text);
            double b = double.Parse(textBox2.Text);

            double res = a * b;

            textBox3.Text = res.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text) || string.IsNullOrWhiteSpace(textBox2.Text))
            {
                return;
            }

            double a = double.Parse(textBox1.Text);
            double b = double.Parse(textBox2.Text);

            double res = a / b;

            textBox3.Text = res.ToString();
        }
    }
}
