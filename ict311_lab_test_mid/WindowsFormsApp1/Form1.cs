using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label1.Text = "ชื่อ";
            label2.Text = "นามสกุล";

            label3.Text = "ชื่อ - นามสกุล";

            textBox3.ReadOnly = true;

            button1.Text = "ตกลง";
            button2.Text = "ปิด";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text) || string.IsNullOrWhiteSpace(textBox2.Text))
            {
                return;
            }

            String full_name = textBox1.Text + " " + textBox2.Text;

            textBox3.Text = full_name;

            MessageBox.Show(full_name);
        }
    }
}
