using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProject
{
    public class Person
    {
        //คลาสแม่ของ PersonReport
        protected string name;
        protected string IDcardNumber;
        protected string AccountName;

        //Getter setter ตัวตั้งค่า และ รีเทิร์นค่าให้ผู้เรียกใช้
        public void SetName(string name)
        {
            this.name = name;
        }
        public void SetID(string ID)
        {
            this.IDcardNumber = ID;
        }
        public void SetAccount(string AccountName)
        {
            this.AccountName = AccountName;
        }

        public  string GetName()
        {
            return this.name;
        }
        public  string GetID()
        {
            return this.IDcardNumber;
        }
        public string GetAccountName()
        {
            return this.AccountName;
        }
        
    }
}
