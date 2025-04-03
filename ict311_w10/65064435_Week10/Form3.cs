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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            label1.Text = "input";
            label2.Text = "output";

            textBox2.ReadOnly = true;

            button1.Text = "equals";
            button2.Text = "length";
            button3.Text = "insert";
            button4.Text = "replace";
            button5.Text = "tolower";
            button6.Text = "toupper";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox2.Text = "abc".Equals("abc").ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox2.Text = textBox1.Text.Length.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox2.Text = "VISUAL STUDIO 2017".Insert(13, " C# ");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox2.Text = "ABCabc".Replace("abc", "zzzzzzzzzzzzzzz");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox2.Text = textBox1.Text.ToLower();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox2.Text = textBox1.Text.ToUpper();
        }
    }
}
