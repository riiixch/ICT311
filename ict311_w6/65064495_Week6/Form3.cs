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
    public partial class Form3 : Form
    {
        String title = "คำนวณอัตราภาษี";

        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            Text = title;

            label1.Text = "รหัสลูกค้า";
            label2.Text = "ราคาสินค้า";
            label3.Text = "อัตราภาษี";
            label4.Text = "ภาษี";
            label5.Text = "ราคาสุทธิ";

            button1.Text = "คำนวณ";
            button2.Text = "ยกเลิก";

            textBox3.ReadOnly = true;
            textBox4.ReadOnly = true;
            textBox5.ReadOnly = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("กรุณษกรอกข้อมูล รหัสลูกค้า", title);
                return;
            }

            if (textBox2.Text == "")
            {
                MessageBox.Show("กรุณษกรอกข้อมูล ราคาสินค้า", title);
                return;
            }

            int cusID, vat = 0;
            Double price, vatVal, finalPrice;

            cusID = int.Parse(textBox1.Text);
            price = Double.Parse(textBox2.Text);

            if (price < 0)
            {
                MessageBox.Show("กรุณษกรอกข้อมูล ราคาสินค้า ให้ถูกต้อง", title);
                return;
            }

            switch (cusID)
            {
                case 0:
                    vat = 0;
                    break;
                case 1:
                    vat = 3;
                    break;
                case 2:
                    vat = 5;
                    break;
                case 3:
                    vat = 7;
                    break;
                case 4:
                    vat = 10;
                    break;
                default:
                    MessageBox.Show("รหัสลูกค้าไม่ถูกต้อง", title);
                    return;
            }

            vatVal = vat * (price / 100);
            finalPrice = price + vatVal;

            textBox3.Text = vat.ToString();
            textBox4.Text = vatVal.ToString();
            textBox5.Text = finalPrice.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
        }
    }
}
