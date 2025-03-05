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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            label1.Text = "คะแนนรวม";
            label2.Text = "คะแนนเฉลี่ย";

            button1.Text = "กรอกคะแนน";

            textBox1.ReadOnly = true;
            textBox2.ReadOnly = true;
            textBox3.ReadOnly = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Double a = 0;

            for (int i = 1; i <= 10; i++)
            {
                String res = Interaction.InputBox("กรุณากรอกคะแนนคนที่ " + i);

                if (string.IsNullOrWhiteSpace(res))
                {
                    res = "0";
                }

                Double s = Double.Parse(res);
                a += s;

                textBox1.Text += "คะแนนคนที่ " + i + " ได้ " + s + Environment.NewLine;
                textBox2.Text = a + "";
                textBox3.Text = a / i + "";
            }
        }
    }
}
