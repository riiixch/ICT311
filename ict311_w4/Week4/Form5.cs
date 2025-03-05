using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Week4
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            Text = "คำนวณค่าอาหาร";

            label1.Text = "ค่าอาหาร";
            label2.Text = "ค่าเครื่องดื่ม";
            label3.Text = "อัตราส่วนลด";
            label4.Text = "ค่าอาหารรวม";
            label5.Text = "ส่วนลด";
            label6.Text = "ราสุทธิ";

            label7.Text = "บาท";
            label8.Text = "บาท";
            label9.Text = "%";
            label10.Text = "บาท";
            label11.Text = "บาท";
            label12.Text = "บาท";

            button1.Text = "คำนวณ";
            button2.Text = "ยกเลิก";

            textBox1.Text = "0";
            textBox2.Text = "0";
            textBox3.Text = "0";

            textBox4.ReadOnly = true;
            textBox5.ReadOnly = true;
            textBox6.ReadOnly = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == null || textBox1.Text == "") {
                textBox1.Text = "0";
            }

            if (textBox2.Text == null || textBox2.Text == "")
            {
                textBox2.Text = "0";
            }

            if (textBox3.Text == null || textBox3.Text == "")
            {
                textBox3.Text = "0";
            }

            Double foodPrice = Double.Parse(textBox1.Text);
            Double drinkPrice = Double.Parse(textBox2.Text);
            Double Discount = Double.Parse(textBox3.Text);

            Double allPrice = foodPrice + drinkPrice;
            Double finalDiscount = (allPrice / 100) * Discount;
            Double finalPrice = allPrice - finalDiscount;

            textBox4.Text = allPrice.ToString();
            textBox5.Text = finalDiscount.ToString();
            textBox6.Text = finalPrice.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
            textBox2.Text = "0";
            textBox3.Text = "0";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
        }
    }
}
