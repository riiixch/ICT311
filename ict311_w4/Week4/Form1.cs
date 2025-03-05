using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Week4
{
    public partial class Form1 : Form
    {
        Double n1, n2, result;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Text = "เครื่องคิดเลข";

            label1.Text = "จำนวนที่ 1";
            label2.Text = "จำนวนที่ 2";
            label3.Text = "ผลลัพธ์";

            button1.Text = "+";
            button2.Text = "-";
            button3.Text = "*";
            button4.Text = "/";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == null || textBox1.Text == "")
            {
                textBox1.Text = "0";
            }

            if (textBox2.Text == null || textBox2.Text == "")
            {
                textBox2.Text = "0";
            }

            n1 = Double.Parse(textBox1.Text);
            n2 = Double.Parse(textBox2.Text);
            result = n1 + n2;

            textBox3.Text = result.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == null || textBox1.Text == "")
            {
                textBox1.Text = "0";
            }

            if (textBox2.Text == null || textBox2.Text == "")
            {
                textBox2.Text = "0";
            }

            n1 = Double.Parse(textBox1.Text);
            n2 = Double.Parse(textBox2.Text);
            result = n1 - n2;

            textBox3.Text = result.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == null || textBox1.Text == "")
            {
                textBox1.Text = "0";
            }

            if (textBox2.Text == null || textBox2.Text == "")
            {
                textBox2.Text = "0";
            }

            n1 = Double.Parse(textBox1.Text);
            n2 = Double.Parse(textBox2.Text);
            result = n1 * n2;

            textBox3.Text = result.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == null || textBox1.Text == "")
            {
                textBox1.Text = "0";
            }

            if (textBox2.Text == null || textBox2.Text == "")
            {
                textBox2.Text = "0";
            }

            n1 = Double.Parse(textBox1.Text);
            n2 = Double.Parse(textBox2.Text);
            result = n1 / n2;

            textBox3.Text = result.ToString();
        }
    }
}
