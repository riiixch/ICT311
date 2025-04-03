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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private Double calculate_1(Double w, Double h)
        {
            return (w * h) * 0.5;
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            label1.Text = "ความยาวฐาน";
            label2.Text = "ความสูง";
            label3.Text = "พื้นที่สามเหลี่ยม";

            label4.Text = "ซม.";
            label5.Text = "ซม.";
            label6.Text = "ซม.";

            button1.Text = "คำนวณ";

            textBox3.ReadOnly = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(textBox1.Text) || String.IsNullOrWhiteSpace(textBox2.Text))
            {
                return;
            }

            textBox3.Text = calculate_1(Double.Parse(textBox1.Text), Double.Parse(textBox2.Text)).ToString();
        }
    }
}
