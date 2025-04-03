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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private Double calVat(Double value)
        {
            if (value < 0 || Double.IsNaN(value))
            {
                return 0.00;
            }

            return (value / 100) * 7;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label1.Text = "ราคาสินค้า";
            label2.Text = "VAT 7%";

            label3.Text = "บาท";
            label4.Text = "บาท";
            
            textBox2.ReadOnly = true;

            button1.Text = "คำนวณ";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text) || Double.IsNaN(Double.Parse(textBox1.Text)))
            {
                textBox1.Text = "";
                textBox2.Text = "";

                return;
            }

            textBox2.Text = calVat(Double.Parse(textBox1.Text)).ToString();
        }
    }
}
