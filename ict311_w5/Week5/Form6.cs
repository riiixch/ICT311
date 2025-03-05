using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Week5
{
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            Text = "คำนวณผลการสอบ";

            label1.Text = "คะแนนคอมพิวเตอร์";
            label2.Text = "คะแนนภาษาอังกฤษ";
            label3.Text = "ผลการสอบ";
            label4.Text = "คะแนน";
            label5.Text = "คะแนน";

            button1.Text = "คำนวณ";
            button2.Text = "ยกเลิก";

            textBox3.ReadOnly = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                textBox1.Text = "0";
            }

            if (textBox2.Text == "")
            {
                textBox2.Text = "0";
            }

            Double scoreIT = Double.Parse(textBox1.Text);
            Double scoreEN = Double.Parse(textBox2.Text);

            if (scoreIT >= 75 && scoreEN >= 70)
            {
                textBox3.Text = "ผ่าน";
            } 
            else
            {
                textBox3.Text = "ไม่ผ่าน";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
        }
    }
}
