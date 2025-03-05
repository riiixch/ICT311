using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _65064435_Mid
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label1.Text = "ค่าอาหาร";
            label2.Text = "ค่าเครื่องดื่ม";
            label3.Text = "ราคารวม";
            label4.Text = "ส่วนลด 5%";
            label5.Text = "ราคาสุธิ";

            label6.Text = "บาท";
            label7.Text = "บาท";
            label8.Text = "บาท";
            label9.Text = "บาท";
            label10.Text = "บาท";

            button1.Text = "คำนวณ";
            button2.Text = "ยกเลิก";

            TxtTotal.ReadOnly = true;
            TxtDiscount.ReadOnly = true;
            TxtPayment.ReadOnly = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text) || string.IsNullOrWhiteSpace(textBox2.Text))
            {
                textBox1.Text = "";
                textBox2.Text = "";

                TxtTotal.Text = "";
                TxtDiscount.Text = "";
                TxtPayment.Text = "";

                return;
            }

            double a_435 = double.Parse(textBox1.Text) + double.Parse(textBox2.Text);
            double d_435 = a_435 * 0.05;
            double f_435 = a_435 - d_435;

            TxtTotal.Text = a_435.ToString();
            TxtDiscount.Text = d_435.ToString();
            TxtPayment.Text = f_435.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";

            TxtTotal.Text = "";
            TxtDiscount.Text = "";
            TxtPayment.Text = "";
        }
    }
}
