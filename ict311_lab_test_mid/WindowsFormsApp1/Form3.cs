using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            label1.Text = "รหัสลูกต้า";
            label2.Text = "ราคาสินค้า";
            label3.Text = "ภาษี (%)";
            label4.Text = "ส่วนลด (%)";

            label5.Text = "ภาษี";
            label6.Text = "ส่วนลด";
            label7.Text = "ราสุธิ";

            textBox4.ReadOnly = true;
            textBox5.ReadOnly = true;
            textBox6.ReadOnly = true;
            textBox7.ReadOnly = true;

            button1.Text = "คำนวณ";
            button2.Text = "ปิด";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text) || string.IsNullOrWhiteSpace(textBox2.Text) || string.IsNullOrWhiteSpace(textBox3.Text))
            {
                return;
            }

            double c_id = double.Parse(textBox1.Text);
            double price = double.Parse(textBox2.Text);
            double vat = double.Parse(textBox3.Text);

            double discount = 0;

            if (c_id == 1)
            {
                discount = 10;
            } else
            if (c_id == 2)
            {
                discount = 20;
            } else
            if (c_id == 3)
            {
                discount = 30;
            }

            double vat_price = (price / 100) * vat;

            price = price + vat_price;

            double discount_price = (price / 100) * discount;

            double final_price = price - discount_price;

            textBox4.Text = discount.ToString();
            textBox5.Text = vat_price.ToString();
            textBox6.Text = discount_price.ToString();
            textBox7.Text = final_price.ToString();
        }
    }
}
