using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _65064495_Week6
{
    public partial class Form6 : Form
    {
        String title = "คำนวณเงินกู้";

        public Form6()
        {
            InitializeComponent();
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            Text = title;

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
                MessageBox.Show("กรุณษกรอกข้อมูล จำนวนสินค้า", title);
                return;
            }

            Double tax = 0, taxVal, money = Double.Parse(textBox1.Text);

            switch (money)
            {
                case Double n when (money > 1000000):
                    tax = 10;
                    break;
                case Double n when (money > 500000):
                    tax = 5;
                    break;
                case Double n when (money <= 500000):
                    tax = 2;
                    break;
            }

            taxVal = (money / 100) * tax;

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
