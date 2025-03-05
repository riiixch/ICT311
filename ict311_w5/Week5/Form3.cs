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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            Text = "คำนวณเกรด";

            label1.Text = "คะแนนสอบ";
            button1.Text = "คำนวณ";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                textBox1.Text = "0";
            }

            Double score = Double.Parse(textBox1.Text);

            if (score >= 80)
            {
                MessageBox.Show("คุณได้เกรด A");
            }
            else
            if (score >= 70)
            {
                MessageBox.Show("คุณได้เกรด B");
            }
            else
            if (score >= 60)
            {
                MessageBox.Show("คุณได้เกรด C");
            }
            else
            if (score >= 50)
            {
                MessageBox.Show("คุณได้เกรด D");
            }
            else
            {
                MessageBox.Show("คุณได้เกรด F");
            }
        }
    }
}
