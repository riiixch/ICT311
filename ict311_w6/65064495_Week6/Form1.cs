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
    public partial class Form1 : Form
    {
        String title = "คำนวณเกรด";

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Text = title;

            label1.Text = "เกรดของคุณ";

            button1.Text = "คำนวณ";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String grade = textBox1.Text.ToUpper();
            String res = "";

            switch (grade)
            {
                case "A":
                    res = "เกรดของคุณอยู่ในระดับดีมาก";
                    break;
                case "B":
                    res = "เกรดของคุณอยู่ในระดับดี";
                    break;
                case "C":
                    res = "เกรดของคุณอยู่ในระดับพอใช้";
                    break;
                case "D":
                    res = "เกรดของคุณอยู่ในระดับแย่";
                    break;
                case "F":
                    res = "เกรดของคุณตก";
                    break;
                default:
                    res = "คุณป้อนข้อมูลเกรดผิด";
                    break;
            }

            MessageBox.Show(res, title);
        }
    }
}
