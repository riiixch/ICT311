using System; // เรียกใช้งานพื้นฐานของ .NET
using System.Collections.Generic; // เรียกใช้งาน List และ Collection อื่นๆ
using System.ComponentModel; // เรียกใช้งาน Component Model
using System.Data; // เรียกใช้งาน DataSet และ DataTable
using System.Drawing; // เรียกใช้งานสำหรับการวาดกราฟิก
using System.Linq; // เรียกใช้งาน LINQ
using System.Text; // เรียกใช้งาน StringBuilder และการจัดการข้อความ
using System.Threading.Tasks; // เรียกใช้งานสำหรับงานแบบ Asynchronous
using System.Windows.Forms; // เรียกใช้งาน Windows Forms
using System.Data.OleDb; // เรียกใช้งาน OleDb เพื่อ Connect Database

namespace _65064435_Week12
{
    public partial class Form1 : Form
    {
        // ตัวแปรสำหรับการเชื่อมต่อฐานข้อมูล
        OleDbConnection Conn = new OleDbConnection(); // Object สำหรับเชื่อมต่อฐานข้อมูล
        ConDB ConDB = new ConDB(); // Object สำหรับจัดการ Connection String (สมมติว่าเป็นคลาสที่สร้างไว้แล้ว)

        // Constructor ของ Form
        public Form1()
        {
            InitializeComponent(); // เริ่มต้น UI Component ที่ออกแบบใน Designer
        }

        // ตรวจสอบการเชื่อมต่อฐานข้อมูล
        private void CheckDatabaseConnect()
        {
            Conn.ConnectionString = ConDB.ConPath; // กำหนด Connection String จาก ConDB

            try
            {
                Conn.Open(); // เปิดการเชื่อมต่อฐานข้อมูล
                //MessageBox.Show("Connection successfuly.", "Connect Database Message"); // แสดงข้อความเมื่อเชื่อมต่อสำเร็จ (ถูกคอมเมนต์ไว้)
                Conn.Close(); // ปิดการเชื่อมต่อ
            }
            catch
            {
                MessageBox.Show("Connection failed!!!", "Connect Database Message"); // แสดงข้อความเมื่อเชื่อมต่อล้มเหลว
                this.Close(); // ปิด Form ถ้าเชื่อมต่อไม่สำเร็จ
            }
        }

        // โหลดข้อมูลจากฐานข้อมูลมาแสดงใน DataGridView
        private void LoadData()
        {
            try
            {
                Conn.Open(); // เปิดการเชื่อมต่อฐานข้อมูล

                String SQL = "select * from CUSTOMER"; // คำสั่ง SQL ดึงข้อมูลทั้งหมดจากตาราง CUSTOMER
                OleDbCommand SQLcmd = new OleDbCommand(SQL, Conn); // สร้างคำสั่ง SQL
                OleDbDataAdapter SQLadapter = new OleDbDataAdapter(SQLcmd); // สร้าง Adapter เพื่อดึงข้อมูล
                DataTable dataTable = new DataTable(); // สร้าง DataTable เพื่อเก็บข้อมูล
                SQLadapter.Fill(dataTable); // เติมข้อมูลลงใน DataTable

                dataGridView1.DataSource = dataTable; // กำหนด DataTable เป็นแหล่งข้อมูลของ DataGridView

                Conn.Close(); // ปิดการเชื่อมต่อ
            }
            catch (Exception ex)
            {
                MessageBox.Show("เกิดข้อผิดพลาด: " + ex.Message); // แสดงข้อความเมื่อเกิดข้อผิดพลาด
            }
        }

        // จัดรูปแบบ DataGridView
        private void FormatDataGridView()
        {
            dataGridView1.ColumnHeadersVisible = true; // แสดงหัวตาราง
            DataGridViewCellStyle columnheaderStyle = new DataGridViewCellStyle(); // สร้างสไตล์สำหรับหัวตาราง
            columnheaderStyle.BackColor = Color.Beige; // กำหนดสีพื้นหลังของหัวตาราง
            columnheaderStyle.Font = new Font("Verdana", 10, FontStyle.Bold); // กำหนดฟอนต์ของหัวตาราง
            dataGridView1.ColumnHeadersDefaultCellStyle = columnheaderStyle; // ใช้สไตล์กับหัวตาราง
            dataGridView1.Columns[0].HeaderText = "รหัสลูกค้า"; // ตั้งชื่อคอลัมน์ 0
            dataGridView1.Columns[1].HeaderText = "ชื่อลูกค้า"; // ตั้งชื่อคอลัมน์ 1
            dataGridView1.Columns[2].HeaderText = "ที่อยู่"; // ตั้งชื่อคอลัมน์ 2
            dataGridView1.Columns[3].HeaderText = "เบอร์โทรศัพท์"; // ตั้งชื่อคอลัมน์ 3
            dataGridView1.Columns[4].HeaderText = "วงเงินการให้สินเชื่อ"; // ตั้งชื่อคอลัมน์ 4
            dataGridView1.Columns[5].HeaderText = "ยอดเงินคงเหลือ"; // ตั้งชื่อคอลัมน์ 5
            dataGridView1.Columns[0].Width = 70; // กำหนดความกว้างคอลัมน์ 0
            dataGridView1.Columns[1].Width = 80; // กำหนดความกว้างคอลัมน์ 1
            dataGridView1.Columns[2].Width = 80; // กำหนดความกว้างคอลัมน์ 2
            dataGridView1.Columns[3].Width = 100; // กำหนดความกว้างคอลัมน์ 3
            dataGridView1.Columns[4].Width = 130; // กำหนดความกว้างคอลัมน์ 4
            dataGridView1.Columns[5].Width = 110; // กำหนดความกว้างคอลัมน์ 5
        }

        // Event เมื่อ Form โหลด
        private void Form1_Load(object sender, EventArgs e)
        {
            CheckDatabaseConnect(); // ตรวจสอบการเชื่อมต่อฐานข้อมูล
            LoadData(); // โหลดข้อมูลลง DataGridView
            FormatDataGridView(); // จัดรูปแบบ DataGridView

            // ตั้งค่าข้อความให้ Label
            label1.Text = "รหัสลูกค้า";
            label2.Text = "ชื่อลูกค้า";
            label3.Text = "ที่อยู่";
            label4.Text = "เบอร์โทรศัพท์";
            label5.Text = "วงเงินการให้สินเชื่อ";
            label6.Text = "เงินคงเหลือ";

            // ตั้งค่าข้อความให้ Button
            button1.Text = "เพิ่ม";
            button2.Text = "แก้ไข";
            button3.Text = "บันทึก";
            button4.Text = "ลบ";
        }

        // Event ปุ่ม "เพิ่ม" - สร้างรหัสลูกค้าใหม่
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Conn.Open(); // เปิดการเชื่อมต่อฐานข้อมูล

                String SQL = "select top 1 C_CODE from CUSTOMER order by C_CODE desc"; // ดึงรหัสลูกค้าล่าสุด
                OleDbDataAdapter SQLadapter = new OleDbDataAdapter SQL, Conn); // สร้าง Adapter เพื่อดึงข้อมูล
                DataTable dataTable = new DataTable(); // สร้าง DataTable เพื่อเก็บข้อมูล
                SQLadapter.Fill(dataTable); // เติมข้อมูลลงใน DataTable

                string tmpid = dataTable.Rows[0]["C_CODE"].ToString(); // ดึงรหัสล่าสุด
                int num_id = int.Parse(tmpid.Remove(0, 1)); // ลบตัว "C" ออกแล้วแปลงเป็นตัวเลข
                num_id += 1; // เพิ่มรหัสขึ้น 1

                // กำหนดค่าเริ่มต้นให้ TextBox
                textBox1.Text = "C" + num_id.ToString("00000"); // รหัสใหม่ในรูปแบบ C00001
                textBox2.Text = ""; // ชื่อว่าง
                textBox3.Text = ""; // ที่อยู่ว่าง
                textBox4.Text = ""; // เบอร์โทรศัพท์ว่าง
                textBox5.Text = "0"; // วงเงินเริ่มต้น 0
                textBox6.Text = "0"; // เงินคงเหลือเริ่มต้น 0

                Conn.Close(); // ปิดการเชื่อมต่อ
            }
            catch (Exception ex)
            {
                MessageBox.Show("เกิดข้อผิดพลาด: " + ex.Message); // แสดงข้อความเมื่อเกิดข้อผิดพลาด
                Conn.Close(); // ปิดการเชื่อมต่อถ้ามีข้อผิดพลาด
            }
        }

        // Event ปุ่ม "แก้ไข" - อัปเดตข้อมูลลูกค้า
        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                Conn.Open(); // เปิดการเชื่อมต่อฐานข้อมูล
                // คำสั่ง SQL สำหรับอัปเดตข้อมูลในตาราง CUSTOMER
                String SQL = "UPDATE CUSTOMER SET CNAME='" + textBox2.Text + "', ADDRESS='" + textBox3.Text + "', TELEPHONE='" + textBox4.Text + "', CREDIT_LIM=" + textBox5.Text + ", CURR_BAL=" + textBox6.Text + " WHERE C_CODE = '" + textBox1.Text + "'";
                OleDbCommand SQLcmd = new OleDbCommand(SQL, Conn); // สร้างคำสั่ง SQL
                SQLcmd.ExecuteNonQuery(); // รันคำสั่ง SQL
                MessageBox.Show("แก้ไขข้อมูลเรียบร้อยแล้วค่ะ"); // แสดงข้อความเมื่อสำเร็จ
                Conn.Close(); // ปิดการเชื่อมต่อ
                LoadData(); // โหลดข้อมูลใหม่ลง DataGridView
            }
            catch (Exception ex)
            {
                MessageBox.Show("เกิดข้อผิดพลาด: " + ex.Message); // แสดงข้อความเมื่อเกิดข้อผิดพลาด
                Conn.Close(); // ปิดการเชื่อมต่อถ้ามีข้อผิดพลาด
            }
        }

        // Event ปุ่ม "บันทึก" - เพิ่มข้อมูลลูกค้าใหม่
        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                Conn.Open(); // เปิดการเชื่อมต่อฐานข้อมูล
                // คำสั่ง SQL สำหรับเพิ่มข้อมูลลงตาราง CUSTOMER
                String SQL = "INSERT INTO CUSTOMER VALUES ('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "'," + textBox5.Text + "," + textBox6.Text + ")";
                OleDbCommand SQLcmd = new OleDbCommand(SQL, Conn); // สร้างคำสั่ง SQL
                SQLcmd.ExecuteNonQuery(); // รันคำสั่ง SQL
                MessageBox.Show("บันทึกข้อมูลเรียบร้อยแล้วค่ะ"); // แสดงข้อความเมื่อสำเร็จ
                Conn.Close(); // ปิดการเชื่อมต่อ
                LoadData(); // โหลดข้อมูลใหม่ลง DataGridView
            }
            catch (Exception ex)
            {
                MessageBox.Show("เกิดข้อผิดพลาด: " + ex.Message); // แสดงข้อความเมื่อเกิดข้อผิดพลาด
                Conn.Close(); // ปิดการเชื่อมต่อถ้ามีข้อผิดพลาด
            }
        }

        // Event ปุ่ม "ลบ" - ลบข้อมูลลูกค้า
        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                Conn.Open(); // เปิดการเชื่อมต่อฐานข้อมูล
                // คำสั่ง SQL สำหรับลบข้อมูลจากตาราง CUSTOMER
                String SQL = "DELETE FROM CUSTOMER WHERE C_CODE = '" + textBox1.Text + "'";
                OleDbCommand SQLcmd = new OleDbCommand(SQL, Conn); // สร้างคำสั่ง SQL
                SQLcmd.ExecuteNonQuery(); // รันคำสั่ง SQL
                MessageBox.Show("ข้อมูลถูกลบแล้วค่ะ"); // แสดงข้อความเมื่อสำเร็จ
                Conn.Close(); // ปิดการเชื่อมต่อ
                LoadData(); // โหลดข้อมูลใหม่ลง DataGridView
            }
            catch (Exception ex)
            {
                MessageBox.Show("เกิดข้อผิดพลาด: " + ex.Message); // แสดงข้อความเมื่อเกิดข้อผิดพลาด
                Conn.Close(); // ปิดการเชื่อมต่อถ้ามีข้อผิดพลาด
            }
        }

        // Event เมื่อคลิกที่เซลล์ใน DataGridView - แสดงข้อมูลใน TextBox
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // ดึงข้อมูลจากแถวที่คลิกมาแสดงใน TextBox
            textBox1.Text = dataGridView1.Rows[e.RowIndex].Cells["C_CODE"].Value.ToString(); // รหัสลูกค้า
            textBox2.Text = dataGridView1.Rows[e.RowIndex].Cells["CNAME"].Value.ToString(); // ชื่อลูกค้า
            textBox3.Text = dataGridView1.Rows[e.RowIndex].Cells["ADDRESS"].Value.ToString(); // ที่อยู่
            textBox4.Text = dataGridView1.Rows[e.RowIndex].Cells["TELEPHONE"].Value.ToString(); // เบอร์โทรศัพท์
            textBox5.Text = dataGridView1.Rows[e.RowIndex].Cells["CREDIT_LIM"].Value.ToString(); // วงเงินสินเชื่อ
            textBox6.Text = dataGridView1.Rows[e.RowIndex].Cells["CURR_BAL"].Value.ToString(); // เงินคงเหลือ
        }
    }
}