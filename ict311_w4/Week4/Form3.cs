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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            label1.Text = "จำนวนแผ่นซีดี";
            label2.Text = "จำนวน";
            label3.Text = "จำนวน";
            label4.Text = "ราคารวม";

            label5.Text = "แผ่น";
            label6.Text = "โหล";
            label7.Text = "แผ่น";
            label8.Text = "บาท";

            button1.Text = "คำนวณ";

            textBox2.ReadOnly = true;
            textBox3.ReadOnly = true;
            textBox4.ReadOnly = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == null || textBox1.Text == "")
            {
                textBox1.Text = "0";
            }

            int n1 = int.Parse(textBox1.Text);
            int pack = n1 / 12;
            int cd = n1 % 12;
            int price = (pack * 100) + (cd * 10);

            textBox2.Text = pack.ToString();
            textBox3.Text = cd.ToString();
            textBox4.Text = price.ToString();
        }
    }
}
