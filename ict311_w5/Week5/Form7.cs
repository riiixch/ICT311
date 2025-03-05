using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Week5
{
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }

        private void Form7_Load(object sender, EventArgs e)
        {
            Text = "คำนวณส่วนลดลูกค้า";

            label1.Text = "จำนวนสินค้า";
            label2.Text = "ส่วนลด";
            label3.Text = "ชิ้น";
            label4.Text = "%";

            groupBox1.Text = "ประเภทลูกค้า";

            radioButton1.Text = "ลูกค้าสมาชิก";
            radioButton2.Text = "ลูกค้าทั่วไป";

            button1.Text = "คำนวณ";
            button2.Text = "ยกเลิก";

            textBox2.ReadOnly = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                textBox1.Text = "0";
            }

            Double amount = Double.Parse(textBox1.Text);

            if (radioButton1.Checked && amount > 20)
            {
                textBox2.Text = "20";
            }
            else
            if (radioButton1.Checked && amount < 20)
            {
                textBox2.Text = "15";
            }
            else
            if (radioButton2.Checked)
            {
                textBox2.Text = "0";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";

            radioButton1.Checked = true;
            radioButton2.Checked = false;
        }
    }
}
