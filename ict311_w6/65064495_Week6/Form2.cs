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
    public partial class Form2 : Form
    {
        String title = "คำนวณอัตราภาษี";

        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            Text = title;

            label1.Text = "รหัสลูกค้า";
            label2.Text = "อัตราภาษี";

            button1.Text = "คำนวณ";
            button2.Text = "ยกเลิก";

            textBox2.ReadOnly = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("กรุณษกรอกข้อมูล", title);
                return;
            }

            int cusID = int.Parse(textBox1.Text);
            String tax;

            switch (cusID)
            {
                case 0:
                    tax = "0";
                    break;
                case 1:
                    tax = "3";
                    break;
                case 2:
                    tax = "5";
                    break;
                case 3:
                    tax = "7";
                    break;
                case 4:
                    tax = "10";
                    break;
                default:
                    MessageBox.Show("รหัสลูกค้าไม่ถูกต้อง", title);
                    return;
            }

            textBox2.Text = tax;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
        }
    }
}
