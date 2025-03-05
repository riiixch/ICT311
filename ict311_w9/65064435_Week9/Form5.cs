using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace _65064435_Week9
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            label1.Text = "คะแนนทั้งหมด";
            label2.Text = "คะแนนรวม";
            label3.Text = "คะแนนเฉลี่ย";
            label4.Text = "คะแนน";
            label5.Text = "คะแนน";

            button1.Text = "กรอกคะแนน";

            textBox1.ReadOnly = true;
            textBox2.ReadOnly = true;
            textBox3.ReadOnly = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Double a = 0;

            int i = 1;
            while (i <= 5)
            {
                String res = Interaction.InputBox("กรอกคะแนนคนที่ " + i);

                if (string.IsNullOrWhiteSpace(res))
                {
                    res = "0";
                }

                Double s = Double.Parse(res);
                a += s;

                textBox1.Text += "คะแนนคนที่ " + i + " ได้ " + s + Environment.NewLine;
                textBox2.Text = a + "";
                textBox3.Text = a / i + "";
                i++;
            }
        }
    }
}
