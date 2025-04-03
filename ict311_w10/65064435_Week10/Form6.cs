using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _65064435_Week10
{
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private Double calculate_price(Double price, Double discountR, Double vatR)
        {
            return price - (price * ((discountR / 100) - (vatR / 100)));
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            label1.Text = "ราคาสินค้า";
            label2.Text = "ส่วนลด";
            label3.Text = "อัตราภาษี";
            label4.Text = "ราคาสุธิ";

            label5.Text = "บาท";
            label6.Text = "%";
            label7.Text = "%";
            label8.Text = "บาท";

            textBox4.ReadOnly = true;

            button1.Text = "คำนวณ";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox4.Text = calculate_price(Double.Parse(textBox1.Text), Double.Parse(textBox2.Text), Double.Parse(textBox3.Text)).ToString();
        }
    }
}
