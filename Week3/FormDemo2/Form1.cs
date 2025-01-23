using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormDemo2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void DemoForm2_Load(object sender, EventArgs e)
        {
            label1.Text = "ชื่อ";
            label2.Text = "นามสกุล";
            label3.Text = "คณะ";
            label4.Text = "สีที่ชอบ";

            radioButton1.Text = "ชาย";
            radioButton2.Text = "หญิง";
            radioButton1.Checked = true;

            groupBox1.Text = "เพศ";

            comboBox1.Items.Add("คณะเทคโนโลยีสารสนเทศ");
            comboBox1.Items.Add("คณะบัญชี");
            comboBox1.Items.Add("คณะบริหารธุรกิจ");
            comboBox1.Items.Add("คณะนิติศาสตร์");
            comboBox1.SelectedIndex = 0;

            listBox1.Items.Add("สีแดง");
            listBox1.Items.Add("สีดำ");
            listBox1.Items.Add("สีทอง");
            listBox1.Items.Add("สีเหลือง");
            listBox1.Items.Add("สีน้ำเงิน");
            listBox1.Items.Add("สีม่วง");
            listBox1.SelectedIndex = 5;

            textBox1.Text = "สมภพ";
            textBox2.Text = "เอี่ยมสมบัติ";

            textBox1.ReadOnly = true;
            textBox2.ReadOnly = true;

            Text = "Demo2";
        }
    }
}
