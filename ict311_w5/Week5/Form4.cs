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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            Text = "คำนวณอัตราภาษี";

            label1.Text = "รหัสลูกค้า";
            label2.Text = "อัตราภาษี";

            button1.Text = "คำนวณ";

            textBox2.ReadOnly = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                textBox1.Text = "0";
            }
            
            Double cusID = Double.Parse(textBox1.Text);

            if (cusID == 0)
            {
                textBox2.Text = "0";
            }
            else
            if (cusID == 1)
            {
                textBox2.Text = "3";
            }
            else
            if (cusID == 2)
            {
                textBox2.Text = "5";
            }
            else
            if (cusID == 3)
            {
                textBox2.Text = "7";
            }
            else
            if (cusID == 4)
            {
                textBox2.Text = "10";
            }
        }
    }
}
