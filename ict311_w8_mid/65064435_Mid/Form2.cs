using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _65064435_Mid
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            label1.Text = "CONVERSION";
            label2.Text = "USD";
            label3.Text = "THB";

            button1.Text = "คำนวณ";
            button2.Text = "ยกเลิก";
            
            textBox2.ReadOnly = true;

            comboBox1.Items.Add("USD TO THB");
            comboBox1.Items.Add("THB TO USD");
            comboBox1.Items.Add("JPY TO THB");
            comboBox1.Items.Add("THB TO JPY");
            comboBox1.Items.Add("EUR TO THB");
            comboBox1.Items.Add("THB TO EUR");
            comboBox1.SelectedIndex = 0;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int s_435 = comboBox1.SelectedIndex;

            if (s_435 == 0)
            {
                label2.Text = "USD";
                label3.Text = "THB";
            } else
            if (s_435 == 1)
            {
                label2.Text = "THB";
                label3.Text = "USD";
            } else
            if (s_435 == 2)
            {
                label2.Text = "JPY";
                label3.Text = "THB";
            } else
            if (s_435 == 3)
            {
                label2.Text = "THB";
                label3.Text = "JPY";
            } else
            if (s_435 == 4)
            {
                label2.Text = "EUR";
                label3.Text = "THB";
            } else
            if (s_435 == 5)
            {
                label2.Text = "THB";
                label3.Text = "EUR";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text))
            {
                comboBox1.SelectedIndex = 0;

                textBox1.Text = "";
                textBox2.Text = "";

                return;
            }

            int s_435 = comboBox1.SelectedIndex;

            if (s_435 == 0)
            {
                double r_435 = double.Parse(textBox1.Text) * 33.735;
                textBox2.Text = r_435.ToString("0.000");
            } else
            if (s_435 == 1)
            {
                double r_435 = double.Parse(textBox1.Text) * 0.030;
                textBox2.Text = r_435.ToString("0.000");
            } else
            if (s_435 == 2)
            {
                double r_435 = double.Parse(textBox1.Text) * 0.230;
                textBox2.Text = r_435.ToString("0.000");
            } else
            if (s_435 == 3)
            {
                double r_435 = double.Parse(textBox1.Text) * 4.433;
                textBox2.Text = r_435.ToString("0.000");
            } else
            if (s_435 == 4)
            {
                double r_435 = double.Parse(textBox1.Text) * 35.421;
                textBox2.Text = r_435.ToString("0.000");
            } else
            if (s_435 == 5)
            {
                double r_435 = double.Parse(textBox1.Text) * 0.028;
                textBox2.Text = r_435.ToString("0.000");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = 0;

            textBox1.Text = "";
            textBox2.Text = "";
        }
    }
}
