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
using System.Windows.Forms.DataVisualization.Charting; // เรียกใช้การสร้าง Chart ด้วย Code

namespace _65064435_Week12
{
    public partial class Form3 : Form
    {
        // ตัวแปรสำหรับการเชื่อมต่อฐานข้อมูล
        OleDbConnection Conn = new OleDbConnection(); // Object สำหรับเชื่อมต่อฐานข้อมูล
        ConDB ConDB = new ConDB(); // Object สำหรับจัดการ Connection String (สมมติว่าเป็นคลาสที่สร้างไว้แล้ว)
        OleDbCommand ConCmd = new OleDbCommand(); // Object สำหรับรันคำสั่ง SQL

        // Constructor ของ Form
        public Form3()
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

        // ตั้งค่า Chart Pie โดยใช้โค้ด ไม่ต้องแก้ใน Designer
        private void setupChart()
        {
            try
            {
                // สร้าง Series ใหม่สำหรับ Chart
                Series series = new Series
                {
                    Name = "Purchase", // ชื่อของ Series
                    ChartType = SeriesChartType.Pie, // กำหนดให้ Chart เป็นแบบ Pie
                    IsValueShownAsLabel = true, // แสดงค่าบน Pie Chart
                };

                chart1.Series.Clear(); // ล้าง Series เดิมทั้งหมดใน Chart
                chart1.Series.Add(series); // เพิ่ม Series ใหม่เข้าไปใน Chart

                // สร้าง Legend (คำอธิบายสี)
                Legend legend = new Legend
                {
                    Name = "Legend1" // ชื่อของ Legend
                };

                chart1.Legends.Clear(); // ล้าง Legend เดิมทั้งหมด
                chart1.Legends.Add(legend); // เพิ่ม Legend ใหม่เข้าไป
            }
            catch (Exception ex)
            {
                MessageBox.Show("เกิดข้อผิดพลาด: " + ex.Message); // แสดงข้อความเมื่อเกิดข้อผิดพลาด
            }
        }

        // โหลดข้อมูลจากฐานข้อมูลมาแสดงใน Pie Chart
        private void loadData()
        {
            try
            {
                chart1.Series["Purchase"].Points.Clear(); // ล้างข้อมูลเก่าใน Series "Purchase"

                Conn.Open(); // เปิดการเชื่อมต่อฐานข้อมูล

                ConCmd.Connection = Conn; // กำหนด Connection ให้ ConCmd

                string sqlchart = "select PNAME, UNIPRICE, ONHAND from PRODUCT"; // คำสั่ง SQL เพื่อดึงข้อมูลชื่อสินค้า, ราคา, และจำนวนคงเหลือ

                ConCmd.CommandText = sqlchart; // กำหนดคำสั่ง SQL ให้ ConCmd

                OleDbDataReader myReader = ConCmd.ExecuteReader(); // อ่านข้อมูลจากฐานข้อมูล

                while (myReader.Read()) // อ่านข้อมูลทีละแถว
                {
                    // เพิ่มข้อมูลลงใน Pie Chart โดยใช้ PNAME เป็น Label และ UNIPRICE เป็นค่า
                    chart1.Series["Purchase"].Points.AddXY(myReader["PNAME"].ToString(), myReader["UNIPRICE"].ToString());
                }

                Conn.Close(); // ปิดการเชื่อมต่อฐานข้อมูล
            }
            catch (Exception ex)
            {
                MessageBox.Show("เกิดข้อผิดพลาด: " + ex.Message); // แสดงข้อความเมื่อเกิดข้อผิดพลาด
            }
        }

        // Event เมื่อ Form โหลด
        private void Form3_Load(object sender, EventArgs e)
        {
            CheckDatabaseConnect(); // ตรวจสอบการเชื่อมต่อฐานข้อมูล
            setupChart(); // ตั้งค่า Chart เมื่อ Form เริ่มทำงาน
        }

        // Event เมื่อกดปุ่ม Button1
        private void button1_Click(object sender, EventArgs e)
        {
            loadData(); // โหลดข้อมูลมาแสดงใน Chart
        }
    }
}