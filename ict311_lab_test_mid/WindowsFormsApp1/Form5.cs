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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            label1.Text = "สินค้า";
            label2.Text = "จำนวน";
            label3.Text = "ราคารวม";
            label4.Text = "ส่วนลด";
            label5.Text = "ราคาสุธิ";

            label6.Text = "ประเภทลูกค้า";

            button1.Text = "คำนวณ";
            button2.Text = "ปิด";

            radioButton1.Text = "ลูกค้าปกติ";
            radioButton2.Text = "ลูกค้าสมาชิก";

            comboBox1.Items.Add("Xiaomi");
            comboBox1.Items.Add("Apple");
            comboBox1.Items.Add("Samsung");
            comboBox1.SelectedIndex = 0;

            textBox2.ReadOnly = true;
            textBox3.ReadOnly = true;
            textBox4.ReadOnly = true;

            radioButton1.Checked = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String product = comboBox1.Text;
            int amount = int.Parse(textBox1.Text);
            double price = 0;
            double discount = 0;
            double discount_price = 0;
            double final_price = 0;

            if (product == "Xiaomi")
            {
                price = 3000;
            } else
            if (product == "Apple")
            {
                price = 22000;
            } else
            if (product == "Samsung")
            {
                price = 300;
            }

            price = price * amount;

            if (radioButton1.Checked)
            {
                discount = 0;
            } else
            if (radioButton2.Checked)
            {
                discount = 25;
            }

            discount_price = (price / 100) * discount;

            final_price = price - discount_price;

            textBox2.Text = price.ToString("0.00");
            textBox3.Text = discount_price.ToString("0.00");
            textBox4.Text = final_price.ToString("0.00");
        }
    }
}
