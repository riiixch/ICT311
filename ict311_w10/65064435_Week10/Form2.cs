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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private Double calDiscount(Double price, Double discountP)
        {
            return (price / 100) * discountP;
        }

        private Double calFinalPrice(Double price, Double discountV)
        {
            return price - discountV;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            label1.Text = "ราคคา";
            label2.Text = "ส่วนลด";
            label3.Text = "ราคาสุธิ";

            label4.Text = "บาท";
            label5.Text = "%";
            label6.Text = "บาท";

            button1.Text = "คำนวณ";

            textBox3.ReadOnly = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(textBox1.Text) || String.IsNullOrWhiteSpace(textBox2.Text))
            {
                return;
            }

            textBox3.Text = calFinalPrice(Double.Parse(textBox1.Text), calDiscount(Double.Parse(textBox1.Text), Double.Parse(textBox2.Text))).ToString();
        }
    }
}
