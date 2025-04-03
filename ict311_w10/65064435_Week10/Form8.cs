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
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
        }

        private void Form8_Load(object sender, EventArgs e)
        {
            label1.Text = "แบบฝึกหัด";
            label2.Text = "การบ้าน";

            button1.Text = "ข้อที่ 1";
            button2.Text = "ข้อที่ 2";
            button3.Text = "ข้อที่ 3";
            button4.Text = "ข้อที่ 4";

            button5.Text = "ข้อที่ 1";
            button6.Text = "ข้อที่ 2";
            button7.Text = "ข้อที่ 3";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new Form1().Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new Form2().Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            new Form3().Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            new Form4().Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            new Form5().Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            new Form6().Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            new Form7().Show();
        }
    }
}
