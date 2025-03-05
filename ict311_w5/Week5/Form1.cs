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
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) {
            Text = "คำนวณคะแนนผ่าน";

            label1.Text = "คะแนนสอบ";
            button1.Text = "คำนวณ";
        }

        private void button1_Click(object sender, EventArgs e) {
            if (textBox1.Text == "") {
                textBox1.Text = "0";
            }

            Double score = Double.Parse(textBox1.Text);

            if (score >= 50) {
                MessageBox.Show("คุณสอบผ่าน");
            }
        }
    }
}
