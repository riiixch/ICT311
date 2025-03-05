using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _65064495_Week6
{
    public partial class Form4 : Form
    {
        String title = "คำนวณประสบการณ์";

        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            Text = title;

            label1.Text = "ประสบการณ์";
            label2.Text = "เงินเดือน";

            label3.Text = "ปี";
            label4.Text = "บาท";

            button1.Text = "คำนวณ";
            button2.Text = "ยกเลิก";

            textBox2.ReadOnly = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("กรุณษกรอกข้อมูล ประสบการณ์", title);
                return;
            }

            int work, salary;
            String salary_messag = "คุณได้รับเงินเดือน ";

            work = int.Parse(textBox1.Text);

            switch (work)
            {
                case int n when (work >= 6):
                    salary = 25000;
                    break;
                case int n when (work >= 4):
                    salary = 20000;
                    break;
                case int n when (work >= 2):
                    salary = 15000;
                    break;
                case int n when (work >= 1):
                    salary = 10000;
                    break;
                case int n when (work < 1):
                    salary = 7500;
                    break;
                default:
                    MessageBox.Show("ประสบการณ์ ไม่ถูกต้อง", title);
                    return;
            }

            textBox2.Text = salary.ToString();
            salary_messag += salary;

            MessageBox.Show(salary_messag, title);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
        }
    }
}
