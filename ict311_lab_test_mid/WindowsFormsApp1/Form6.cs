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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            label1.Text = "เลือกสินค้า";
            label2.Text = "จำนวนสินค้า";

            label3.Text = "ราคาสินค้า";
            label4.Text = "ราคารวม";
            label5.Text = "ส่วนลด";
            label6.Text = "ราคาสุธิ";

            label7.Text = "ประเภทลูกค้า";
            label8.Text = "ฟีเจอร์";

            radioButton1.Text = "ลูกค้าปกติ";
            radioButton2.Text = "ลูกค้าสมาชิก";
            radioButton1.Checked = true;

            checkBox1.Text = "Wifi (ฟรี)";
            checkBox2.Text = "4G LTE (เพิ่มเงิน 2000)";
            checkBox3.Text = "SD Card Reader (เพิ่มเงิน 3000)";
            checkBox4.Text = "Camera (เพิ่มเงิน 7000)";

            comboBox1.Items.Add("AMD");
            comboBox1.Items.Add("Intel");
            comboBox1.SelectedIndex = 0;

            textBox2.ReadOnly = true;
            textBox3.ReadOnly = true;
            textBox4.ReadOnly = true;
            textBox5.ReadOnly = true;

            button1.Text = "คำนวณ";
            button2.Text = "ปิด";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String product = comboBox1.Text;
            double price = 0;

            if (product == "AMD")
            {
                price = 2000;
            } else
            if (product == "Intel")
            {
                price = 20;
            }

            int amount = int.Parse(textBox1.Text);

            if (checkBox1.Checked)
            {
                price += 0;
            }

            if (checkBox2.Checked)
            {
                price += 2000;
            }

            if (checkBox3.Checked)
            {
                price += 3000;
            }

            if (checkBox4.Checked)
            {
                price += 7000;
            }

            double all_price = price * amount;

            double discount = 0;

            if (radioButton1.Checked)
            {
                discount = 0;
            } else
            if (radioButton2.Checked)
            {
                discount = 10.89;
            }

            double discount_price = (all_price / 100) * discount;

            double final_price = all_price - discount_price;

            textBox2.Text = price.ToString("0.00");
            textBox3.Text = all_price.ToString("0.00");
            textBox4.Text = discount_price.ToString("0.00");
            textBox5.Text = final_price.ToString("0.00");
        }
    }
}
