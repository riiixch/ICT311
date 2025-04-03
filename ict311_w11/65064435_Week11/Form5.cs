using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace _65064435_Week11
{
    public partial class Form5 : Form
    {
        OleDbConnection connection = new OleDbConnection();
        Class1 objA = new Class1();

        public Form5()
        {
            InitializeComponent();
        }

        private void connectionDatabase()
        {
            connection.ConnectionString = objA.strA;

            try
            {
                connection.Open();
                MessageBox.Show("Connection success");
                connection.Close();
            }
            catch
            {
                MessageBox.Show("Connection failed");
            }
        }

        private void LoadData()
        {
            try
            {
                connection.Open();
                OleDbCommand command = new OleDbCommand("SELECT * FROM EMPLOYEE", connection);
                OleDbDataAdapter adapter = new OleDbDataAdapter(command);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dataGridView1.DataSource = dt;
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("เกิดข้อผิดพลาด: " + ex.Message);
            }
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            label1.Text = "รหัสพนักงาน";
            label2.Text = "ชื่อพนักงาน";
            label3.Text = "ที่อยู่";
            label4.Text = "เบอร์โทรศัพท์";
            label5.Text = "ตำหน่งงาน";
            label6.Text = "เงินเดือน";

            button1.Text = "เพิ่ม";
            button2.Text = "แก้ไข";
            button3.Text = "บันทึก";
            button4.Text = "ลบ";

            connectionDatabase();
            LoadData();
        }
    }
}
