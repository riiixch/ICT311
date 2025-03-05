using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace _65064435_Week9
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            button1.Text = "กรอกองศา C";

            textBox1.ReadOnly = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Double f, c;
            for (int i = 1; i <= 5; i++)
            {
                String res = Interaction.InputBox("กรุณากรอกองศา C");

                if (string.IsNullOrWhiteSpace(res))
                {
                    return;
                }

                c = Double.Parse(res);
                f = (1.8 * c) + 33;
                textBox1.Text += f + Environment.NewLine;
            }
        }
    }
}
