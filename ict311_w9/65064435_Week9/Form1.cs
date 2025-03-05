using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _65064435_Week9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            button1.Text = "For 1-10 Single";
            button2.Text = "For 1-10 All";
            button3.Text = "For 1-10 twin";
            button4.Text = "For 1-10 odd";
            button5.Text = "For 10-0";
            button6.Text = "For 20-0 twin";
            button7.Text = "For 20-0 odd";
            button8.Text = "While 1-10";
            button9.Text = "While 0-10 twin";
            button10.Text = "While 10-1";
            button11.Text = "Do While 1-10";
            button12.Text = "Do While 0-10";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = 1; i <= 10; i++)
            {
                MessageBox.Show(i.ToString());
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            String msg = "";
            for (int i = 1; i <= 10; i++)
            {
                msg += "รอบที่ " + i + "\n";
            }
            MessageBox.Show(msg);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            for (int i = 2; i <= 10; i+= 2)
            {
                MessageBox.Show(i.ToString());
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            for (int i = 1; i <= 10; i+= 2)
            {
                MessageBox.Show(i.ToString());
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            for (int i = 10; i >= 0; i--)
            {
                MessageBox.Show(i.ToString());
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            for (int i = 20; i >= 0; i-=2)
            {
                MessageBox.Show(i.ToString());
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            for (int i = 19; i >= 0; i -= 2)
            {
                MessageBox.Show(i.ToString());
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            int i = 1;
            String msg = "";

            while (i <= 10)
            {
                msg += "รอบที่ " + i + "\n";

                i++;
            }

            MessageBox.Show(msg);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            int i = 0;
            String msg = "";

            while (i <= 10)
            {
                msg += "รอบที่ " + i + "\n";

                i+=2;
            }

            MessageBox.Show(msg);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            int i = 10;
            String msg = "";

            while (i >= 1)
            {
                msg += "รอบที่ " + i + "\n";

                i--;
            }

            MessageBox.Show(msg);
        }

        private void button11_Click(object sender, EventArgs e)
        {
            int i = 1;
            String msg = "";

            do
            {
                msg += "รอบที่ " + i + "\n";

                i++;
            } while (i <= 10);

            MessageBox.Show(msg);
        }

        private void button12_Click(object sender, EventArgs e)
        {
            int i = 0;
            String msg = "";

            do
            {
                msg += "รอบที่ " + i + "\n";

                i++;
            } while (i <= 10);

            MessageBox.Show(msg);
        }
    }
}
