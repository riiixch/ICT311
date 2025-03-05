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
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
        }

        private void Form8_Load(object sender, EventArgs e)
        {
            Text = "คำนวณเงินกู้";

            label1.Text = "เงินกู้";
            label2.Text = "อัตาค่าธรรมเนียม";
            label3.Text = "ค่าธรรมเนียม";
            label4.Text = "บาท";
            label5.Text = "%";
            label6.Text = "บาท";

            button1.Text = "คำนวณ";
            button2.Text = "ยกเลิก";

            textBox2.ReadOnly = true;
            textBox3.ReadOnly = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                textBox1.Text = "0";
            }

            Double amount = Double.Parse(textBox1.Text);
            Double tax = 0;
            Double taxVal = 0;

            if (amount > 1000000)
            {
                tax = 10;
            }
            else
            if (amount > 500000)
            {
                tax = 5;
            }
            else
            {
                tax = 2;
            }

            taxVal = (amount / 100) * tax;

            textBox2.Text = tax.ToString();
            textBox3.Text = taxVal.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
        }
    }
}
