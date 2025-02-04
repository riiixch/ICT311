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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            Text = "คำนวณอุณหภูมิเฉลี่ย";

            label1.Text = "อุณหภูมิสูงสุด";
            label2.Text = "อุณหภูมิต่ำสุด";
            label3.Text = "อุณหภูมิเฉลี่ย";

            button1.Text = "คำนวณ";
            button2.Text = "ยกเลิก";
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

            Double n1 = Double.Parse(textBox1.Text);
            Double n2 = Double.Parse(textBox2.Text);
            Double result = (n1 + n2) / 2;

            textBox3.Text = result.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
            textBox2.Text = "0";
            textBox3.Text = "0";
        }
    }
}
