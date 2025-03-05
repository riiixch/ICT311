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
    public partial class Form5 : Form
    {
        String title = "คำนวณประสบการณ์";

        public Form5()
        {
            InitializeComponent();
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            Text = title;

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
                MessageBox.Show("กรุณษกรอกข้อมูล จำนวนสินค้า", title);
                return;
            }

            Double discount, amount = Double.Parse(textBox1.Text);
            Boolean member = radioButton1.Checked;

            switch (amount)
            {
                case Double n when (amount >= 20 && member == true):
                    discount = 20;
                    break;
                case Double n when (amount < 20 && member == true):
                    discount = 15;
                    break;
                case Double n when (amount > 0 && member != true):
                    discount = 0;
                    break;
                default:
                    MessageBox.Show("จำนวนสินค้า ไม่ถูกต้อง", title);
                    return;
            }

            textBox2.Text = discount.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
        }
    }
}
