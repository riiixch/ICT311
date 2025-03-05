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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            label1.Text = "เลือกรหัสลูกค้า";
            label2.Text = "ราคาสินค้า";
            label3.Text = "อัตราภาษี";

            label4.Text = "ภาษี";
            label5.Text = "ราคาหลังบวกภาษี";
            label6.Text = "ส่วนลด (%)";
            label7.Text = "ส่วนลด (บาท)";
            label8.Text = "ราคาสุธิ";

            textBox2.ReadOnly = true;
            textBox3.ReadOnly = true;
            textBox4.ReadOnly = true;
            textBox5.ReadOnly = true;
            textBox6.ReadOnly = true;

            button1.Text = "คำนวณ";
            button2.Text = "ปิด";

            comboBox1.Items.Add("1");
            comboBox1.Items.Add("2");
            comboBox1.Items.Add("3");
            comboBox1.SelectedIndex = 0;

            comboBox2.Items.Add("3");
            comboBox2.Items.Add("5");
            comboBox2.Items.Add("7");
            comboBox2.SelectedIndex = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(comboBox1.Text) || string.IsNullOrWhiteSpace(textBox1.Text) || string.IsNullOrWhiteSpace(comboBox2.Text))
            {
                return;
            }

            double c_id = double.Parse(comboBox1.Text);
            double price = double.Parse(textBox1.Text);
            double vat = double.Parse(comboBox2.Text);

            double discount = 0;

            if (c_id == 1)
            {
                discount = 10;
            }
            else
            if (c_id == 2)
            {
                discount = 20;
            }
            else
            if (c_id == 3)
            {
                discount = 30;
            }

            double vat_price = (price / 100) * vat;

            price = price + vat_price;

            double discount_price = (price / 100) * discount;

            double final_price = price - discount_price;

            textBox2.Text = vat_price.ToString();
            textBox3.Text = price.ToString();
            textBox4.Text = discount.ToString();
            textBox5.Text = discount_price.ToString();
            textBox6.Text = final_price.ToString();
        }
    }
}
