using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _65064435_Week11
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            label1.Text = "วันที่เริ่มต้น";
            label2.Text = "วันที่สิ้นสุด";

            button1.Text = "คำนวณวัน";
            button2.Text = "บวกวัน";

            dateTimePicker1.Format = DateTimePickerFormat.Short;
            dateTimePicker2.Format = DateTimePickerFormat.Long;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int n = dateTimePicker2.Value.Subtract(dateTimePicker1.Value).Days;
            MessageBox.Show("ผลต่างของวันที่คุณเลือก ต่างกัน " + n + " วัน");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show(dateTimePicker2.Value.AddDays(20).ToString());
        }
    }
}
