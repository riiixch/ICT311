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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            Text = "คำนวนราสินค้าสมาชิก";

            label1.Text = "รหัสลูกค้า";
            label2.Text = "ค่าสินค้า";
            label3.Text = "อัตราภาษี";
            label4.Text = "ภาษี";
            label5.Text = "ราคาสินค้าสุทธิ";
            label6.Text = "บาท";

            button1.Text = "คำนวณ";
            button2.Text = "ยกเลิก";

            textBox3.ReadOnly = true;
            textBox4.ReadOnly = true;
            textBox5.ReadOnly = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                textBox1.Text = "0";
            }

            if (textBox2.Text == "")
            {
                textBox2.Text = "0";
            }

            Double cusID = Double.Parse(textBox1.Text);
            Double val = Double.Parse(textBox2.Text);
            Double tax = 0;
            Double taxVal = 0;
            Double finalVal = 0;

            if (cusID == 0)
            {
                tax = 0;
            }
            else
            if (cusID == 1)
            {
                tax = 3;
            }
            else
            if (cusID == 2)
            {
                tax = 5;
            }
            else
            if (cusID == 3)
            {
                tax = 7;
            }
            else
            if (cusID == 4)
            {
                tax = 10;
            }

            taxVal = (val / 100) * tax;
            finalVal = val + taxVal;

            textBox3.Text = tax.ToString();
            textBox4.Text = taxVal.ToString();
            textBox5.Text = finalVal.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
        }
    }
}
