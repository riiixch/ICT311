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
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }

        private Double calculate_1(Double r)
        {
            return (r * r) * 3.14;
        }

        private void Form7_Load(object sender, EventArgs e)
        {
            label1.Text = "รัศมีของวงกลม";
            label2.Text = "พื้นที่วงกลม";

            button1.Text = "คำนวณ";

            textBox2.ReadOnly = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox2.Text = calculate_1(Double.Parse(textBox1.Text)).ToString();
        }
    }
}
