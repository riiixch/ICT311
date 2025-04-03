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
    public partial class Form2 : Form
    {
        // ตัวแปรสำหรับการเชื่อมต่อฐานข้อมูล
        OleDbConnection Conn = new OleDbConnection(); // Object สำหรับเชื่อมต่อฐานข้อมูล
        ConDB ConDB = new ConDB(); // Object สำหรับจัดการ Connection String (สมมติว่าเป็นคลาสที่สร้างไว้แล้ว)

        // Constructor ของ Form
        public Form2()
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

        // โหลดข้อมูลพนักงานจากฐานข้อมูลมาแสดงใน DataGridView
        private void LoadData()
        {
            try
            {
                Conn.Open(); // เปิดการเชื่อมต่อฐานข้อมูล

                // คำสั่ง SQL ดึงข้อมูลพนักงานพร้อมตำแหน่งงาน โดยใช้ INNER JOIN ระหว่างตาราง EMPLOYEE และ POS
                String SQL = "select EMPLOYEE.EMP_CODE, EMPLOYEE.EMP_NAME, EMPLOYEE.ADDRESS, EMPLOYEE.EMP_TELEPHONE, POS.POSITION_NAME, EMPLOYEE.SALARY from EMPLOYEE inner join POS on EMPLOYEE.POSITION_CODE = POS.POSITION_CODE;";
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

        // โหลดข้อมูลตำแหน่งงานลงใน ComboBox
        private void LoadPos()
        {
            try
            {
                Conn.Open(); // เปิดการเชื่อมต่อฐานข้อมูล

                String SQL = "select * from POS"; // คำสั่ง SQL ดึงข้อมูลทั้งหมดจากตาราง POS
                OleDbCommand SQLcmd = new OleDbCommand(SQL, Conn); // สร้างคำสั่ง SQL
                OleDbDataAdapter SQLadapter = new OleDbDataAdapter(SQLcmd); // สร้าง Adapter เพื่อดึงข้อมูล
                DataTable dataTable = new DataTable(); // สร้าง DataTable เพื่อเก็บข้อมูล
                SQLadapter.Fill(dataTable); // เติมข้อมูลลงใน DataTable

                comboBox1.DataSource = dataTable; // กำหนด DataTable เป็นแหล่งข้อมูลของ ComboBox
                comboBox1.DisplayMember = "POSITION_NAME"; // กำหนดให้แสดงชื่อตำแหน่ง
                comboBox1.ValueMember = "POSITION_CODE"; // กำหนดให้เก็บรหัสตำแหน่งเป็นค่า

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
            dataGridView1.Columns[0].HeaderText = "รหัสพนักงาน"; // ตั้งชื่อคอลัมน์ 0
            dataGridView1.Columns[1].HeaderText = "ชื่อพนักงาน"; // ตั้งชื่อคอลัมน์ 1
            dataGridView1.Columns[2].HeaderText = "ที่อยู่"; // ตั้งชื่อคอลัมน์ 2
            dataGridView1.Columns[3].HeaderText = "เบอร์โทรศัพท์"; // ตั้งชื่อคอลัมน์ 3
            dataGridView1.Columns[4].HeaderText = "ตำแหน่งงาน"; // ตั้งชื่อคอลัมน์ 4
            dataGridView1.Columns[5].HeaderText = "เงินคงเดือน"; // ตั้งชื่อคอลัมน์ 5
            dataGridView1.Columns[0].Width = 90; // กำหนดความกว้างคอลัมน์ 0
            dataGridView1.Columns[1].Width = 90; // กำหนดความกว้างคอลัมน์ 1
            dataGridView1.Columns[2].Width = 80; // กำหนดความกว้างคอลัมน์ 2
            dataGridView1.Columns[3].Width = 100; // กำหนดความกว้างคอลัมน์ 3
            dataGridView1.Columns[4].Width = 130; // กำหนดความกว้างคอลัมน์ 4
            dataGridView1.Columns[5].Width = 110; // กำหนดความกว้างคอลัมน์ 5
        }

        // Event เมื่อ Form โหลด
        private void Form2_Load(object sender, EventArgs e)
        {
            CheckDatabaseConnect(); // ตรวจสอบการเชื่อมต่อฐานข้อมูล
            LoadData(); // โหลดข้อมูลพนักงานลง DataGridView
            LoadPos(); // โหลดข้อมูลตำแหน่งงานลง ComboBox
            FormatDataGridView(); // จัดรูปแบบ DataGridView

            // ตั้งค่าข้อความให้ Label
            label1.Text = "รหัสพนักงาน";
            label2.Text = "ชื่อพนักงาน";
            label3.Text = "ที่อยู่";
            label4.Text = "เบอร์โทรศัพท์";
            label5.Text = "ตำแหน่งงาน";
            label6.Text = "เงินคงเดือน";

            // ตั้งค่าข้อความให้ Button
            button1.Text = "เพิ่ม";
            button2.Text = "แก้ไข";
            button3.Text = "บันทึก";
            button4.Text = "ลบ";
        }

        // Event ปุ่ม "เพิ่ม" - สร้างรหัสพนักงานใหม่
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Conn.Open(); // เปิดการเชื่อมต่อฐานข้อมูล

                String SQL = "select top 1 EMP_CODE from EMPLOYEE order by EMP_CODE desc"; // ดึงรหัสพนักงานล่าสุด
                OleDbDataAdapter SQLadapter = new OleDbDataAdapter(SQL, Conn); // สร้าง Adapter เพื่อดึงข้อมูล
                DataTable dataTable = new DataTable(); // สร้าง DataTable เพื่อเก็บข้อมูล
                SQLadapter.Fill(dataTable); // เติมข้อมูลลงใน DataTable

                // ตรวจสอบว่ามีข้อมูลหรือไม่ ถ้าไม่มีให้เริ่มที่ E00000
                string tmpid = dataTable.Rows.Count > 0 ? dataTable.Rows[0]["EMP_CODE"].ToString() : "E00000";
                int num_id = int.Parse(tmpid.Remove(0, 1)); // ลบตัว "E" ออกแล้วแปลงเป็นตัวเลข
                num_id += 1; // เพิ่มรหัสขึ้น 1

                // กำหนดค่าเริ่มต้นให้ TextBox และ ComboBox
                textBox1.Text = "E" + num_id.ToString("00000"); // รหัสใหม่ในรูปแบบ E00001
                textBox2.Text = ""; // ชื่อว่าง
                textBox3.Text = ""; // ที่อยู่ว่าง
                textBox4.Text = ""; // เบอร์โทรศัพท์ว่าง
                comboBox1.SelectedIndex = 0; // เลือกตำแหน่งแรกใน ComboBox
                textBox5.Text = "0"; // เงินเดือนเริ่มต้น 0

                Conn.Close(); // ปิดการเชื่อมต่อ
            }
            catch (Exception ex)
            {
                MessageBox.Show("เกิดข้อผิดพลาด: " + ex.Message); // แสดงข้อความเมื่อเกิดข้อผิดพลาด
                Conn.Close(); // ปิดการเชื่อมต่อถ้ามีข้อผิดพลาด
            }
        }

        // Event ปุ่ม "แก้ไข" - อัปเดตข้อมูลพนักงาน
        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                Conn.Open(); // เปิดการเชื่อมต่อฐานข้อมูล
                // คำสั่ง SQL สำหรับอัปเดตข้อมูลในตาราง EMPLOYEE
                String SQL = "UPDATE EMPLOYEE SET EMP_NAME='" + textBox2.Text + "', ADDRESS='" + textBox3.Text + "', EMP_TELEPHONE='" + textBox4.Text + "', POSITION_CODE='" + comboBox1.SelectedValue.ToString() + "', SALARY=" + textBox5.Text + " WHERE EMP_CODE = '" + textBox1.Text + "'";
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

        // Event ปุ่ม "บันทึก" - เพิ่มข้อมูลพนักงานใหม่
        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                Conn.Open(); // เปิดการเชื่อมต่อฐานข้อมูล
                // คำสั่ง SQL สำหรับเพิ่มข้อมูลลงตาราง EMPLOYEE
                String SQL = "INSERT INTO EMPLOYEE (EMP_CODE, EMP_NAME, ADDRESS, EMP_TELEPHONE, POSITION_CODE, SALARY) VALUES ('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "','" + comboBox1.SelectedValue.ToString() + "'," + textBox5.Text + ")";
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

        // Event ปุ่ม "ลบ" - ลบข้อมูลพนักงาน
        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                Conn.Open(); // เปิดการเชื่อมต่อฐานข้อมูล
                // คำสั่ง SQL สำหรับลบข้อมูลจากตาราง EMPLOYEE
                String SQL = "DELETE FROM EMPLOYEE WHERE EMP_CODE = '" + textBox1.Text + "'";
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

        // Event เมื่อคลิกที่เซลล์ใน DataGridView - แสดงข้อมูลใน TextBox และ ComboBox
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // ดึงข้อมูลจากแถวที่คลิกมาแสดงใน TextBox และ ComboBox
            textBox1.Text = dataGridView1.Rows[e.RowIndex].Cells["EMP_CODE"].Value.ToString(); // รหัสพนักงาน
            textBox2.Text = dataGridView1.Rows[e.RowIndex].Cells["EMP_NAME"].Value.ToString(); // ชื่อพนักงาน
            textBox3.Text = dataGridView1.Rows[e.RowIndex].Cells["ADDRESS"].Value.ToString(); // ที่อยู่
            textBox4.Text = dataGridView1.Rows[e.RowIndex].Cells["EMP_TELEPHONE"].Value.ToString(); // เบอร์โทรศัพท์
            comboBox1.Text = ""; // ล้างค่าใน ComboBox ก่อน
            comboBox1.SelectedText = dataGridView1.Rows[e.RowIndex].Cells["POSITION_NAME"].Value.ToString(); // แสดงชื่อตำแหน่งใน ComboBox
            textBox5.Text = dataGridView1.Rows[e.RowIndex].Cells["SALARY"].Value.ToString(); // เงินเดือน
        }
    }
}