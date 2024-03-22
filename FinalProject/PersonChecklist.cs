using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject
{
    public class PersonChecklist : PersonReport
    {
        //สืบทอดมาจาก PersonReport
        private DatabaseBLacklist database = new DatabaseBLacklist();
        //ฟังก์ชัน ตรวจสอบผู้ขายที่โดนBlacklist
        public PersonChecklist CheckList(PersonChecklist personChecklist)
        {
            //Searching
            List<PersonChecklist> list = database.CheckList();
            PersonChecklist Person = new PersonChecklist();
            //ถ้าหาก จำนวนใน List มี 0 (หมายความว่าไม่มีข้อมูล
            Person.SetName("");
            //หาก ข้อมูลใน list ไม่มีจะทำการ คืนค่า Person ที่มีค่่า Name = ""
            if (list.Count == 0)
            {
                return Person;
            }
            foreach(PersonChecklist person in list)
            {
                //ตรวจสอบว่ามีค่าใดบ้างใน ดาต้าเบสที่แต่ละฟิลด์มีข้อมูลตรงกับ ที่ user ป้อนเข้ามาในหน้าตรวจสอบ
                if (personChecklist.GetName() == person.GetName() || personChecklist.GetID() == person.GetID() || personChecklist.GetAccountName() == person.GetAccountName() || personChecklist.GetMarketAcc() == person.GetMarketAcc())
                {
                    return person;
                }


            }
            return Person;
        }
    }
}
