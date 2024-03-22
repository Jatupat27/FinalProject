using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject
{
    internal class DatabaseBLacklist
    {

        private CSV csv = new CSV();
        //รับพารามิเตอร์เป็นอ็อบเจ็คจากคลาส PersonReport
        public bool Report(PersonReport person)
        {
            csv.Savetofile(person);
            return true;
        }
        public List<PersonChecklist> CheckList()
        {
            //Searching
            List<PersonChecklist> checklist = new List<PersonChecklist>();
            string[] content = csv.GetData();
            if (content.Length == 0)
            {
                return checklist;
            }
            else
            {
                foreach (string lines in content)
                {
                    PersonChecklist person = new PersonChecklist();
                    string[] line = lines.Split(',');

                    person.SetName(line[0]);
                    person.SetID(line[1]);
                    person.SetAccount(line[2]);
                    person.SetProduct(line[3]);
                    person.SetMarketAccount(line[4].Split(':')[1]);
                    person.SetMarketPlace(line[4].Split(':')[0]);
                    checklist.Add(person);
                }

            }
            return checklist;
            
        }
        
    }
}
