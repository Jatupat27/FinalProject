using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProject
{
    public class CSV
    {
        //path ที่อยู่ไฟล์
        private string path = @"D:\OOP\FinalProject\Data.csv";
        //อาเรย์ของข้อความ
        private string[] content = new string[] { } ;


        public bool Savetofile(PersonReport person)
        {
            //ข้อมูลสำหรับเขียนไฟล์
            string content = person.GetName() + "," + person.GetID() + "," + person.GetAccountName() + "," + person.GetProduct() + "," + person.GetMarketPlace() +":"+ person.GetMarketAcc()+"\n";
            try
            {
                File.WriteAllText(path, content);
                return true;
            }
            catch
            {
                return false;
            }
        }
        //ฟังก์ชันเขียนไฟล์
        public bool Readfile()
        {
            try
            {
                content = File.ReadAllLines(path);
                return true;
            }
            catch
            {
                return false;
            }

        }
        //ฟังก์ชันคืนค่าข้อมูลที่อ่านเข้ามา
        public string[] GetData()
        {
            Readfile();
            return content;
        }
    }
}
