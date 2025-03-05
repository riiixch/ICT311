using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _65064495_Week7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label1.Text = "Conversion";
            label2.Text = "MILE";
            label3.Text = "KILOMETER";

            textBox2.ReadOnly = true;

            button1.Text = "Calculate";
            button2.Text = "Exit";

            comboBox1.Items.Add("MILE TO KILOMETER");
            comboBox1.Items.Add("KILOMETER TO MILE");
            comboBox1.Items.Add("FEET TO METER");
            comboBox1.Items.Add("METER TO FEET");
            comboBox1.Items.Add("INCHES TO CENTIMETER");
            comboBox1.Items.Add("CENTIMETER TO INCHES");

            comboBox1.SelectedIndex = 0;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            String convert = comboBox1.Text;

            switch (convert)
            {
                case "MILE TO KILOMETER":
                    label2.Text = "MILE";
                    label3.Text = "KILOMETER";
                    break;
                case "KILOMETER TO MILE":
                    label2.Text = "KILOMETER";
                    label3.Text = "MILE";
                    break;
                case "FEET TO METER":
                    label2.Text = "FEET";
                    label3.Text = "METER";
                    break;
                case "METER TO FEET":
                    label2.Text = "METER";
                    label3.Text = "FEET";
                    break;
                case "INCHES TO CENTIMETER":
                    label2.Text = "INCHES";
                    label3.Text = "CENTIMETER";
                    break;
                case "CENTIMETER TO INCHES":
                    label2.Text = "CENTIMETER";
                    label3.Text = "INCHES";
                    break;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Double input, output;
            String convert = comboBox1.Text;

            if (textBox1.Text == null || textBox1.Text == "")
            {
                return;
            }

            input = Double.Parse(textBox1.Text);

            switch (convert)
            {
                case "MILE TO KILOMETER":
                    output = input * 1.6093;
                    textBox2.Text = output.ToString();
                    break;
                case "KILOMETER TO MILE":
                    output = input * 0.6214;
                    textBox2.Text = output.ToString();
                    break;
                case "FEET TO METER":
                    output = input * 0.3048;
                    textBox2.Text = output.ToString();
                    break;
                case "METER TO FEET":
                    output = input * 3.2808;
                    textBox2.Text = output.ToString();
                    break;
                case "INCHES TO CENTIMETER":
                    output = input * 2.54;
                    textBox2.Text = output.ToString();
                    break;
                case "CENTIMETER TO INCHES":
                    output = input * 0.3937;
                    textBox2.Text = output.ToString();
                    break;
            }
        }
    }
}
