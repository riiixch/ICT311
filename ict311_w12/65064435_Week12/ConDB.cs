using System; // เรียกใช้งานพื้นฐานของ .NET
using System.Collections.Generic; // เรียกใช้งาน List และ Collection อื่นๆ
using System.Linq; // เรียกใช้งาน LINQ
using System.Text; // เรียกใช้งาน StringBuilder และการจัดการข้อความ
using System.Threading.Tasks; // เรียกใช้งานสำหรับงานแบบ Asynchronous

namespace _65064435_Week12
{
    // คลาสสำหรับจัดการ Connection String ของฐานข้อมูล
    class ConDB
    {
        // ตัวแปรสาธารณะเก็บ Connection String
        public string ConPath = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\GUDJUNG_MINIMART.accdb";
        // คำอธิบาย:
        // - Provider=Microsoft.ACE.OLEDB.12.0 : ระบุว่าใช้ OLE DB Provider สำหรับ Microsoft Access
        // - Data Source=|DataDirectory|\GUDJUNG_MINIMART.accdb : ระบุตำแหน่งไฟล์ฐานข้อมูล Access ชื่อ GUDJUNG_MINIMART.accdb
        // - |DataDirectory| : เป็นตัวแปรพิเศษที่ชี้ไปยังโฟลเดอร์ App_Data หรือโฟลเดอร์ที่กำหนดในโปรเจค
    }
}