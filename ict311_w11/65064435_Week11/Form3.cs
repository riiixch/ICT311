using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _65064435_Week11
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            label1.Text = "จำนวนที่ 1";
            label2.Text = "จำนวนที่ 2";
            label3.Text = "ผลลัพธ์";

            button1.Text = "คำนวณ (ปกติ)";
            button2.Text = "คำนวณ (try catch)";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox3.Text = (Double.Parse(textBox1.Text) * Double.Parse(textBox2.Text)).ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                textBox3.Text = (Double.Parse(textBox1.Text) * Double.Parse(textBox2.Text)).ToString();
            }
            catch
            {
                MessageBox.Show("ตรวจสอยค่าให้ถูกต้อง");

                textBox1.Text = "0";
                textBox2.Text = "0";
                textBox3.Text = "0";
            }
        }
    }
}
