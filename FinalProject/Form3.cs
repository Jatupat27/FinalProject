using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProject
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        private PersonChecklist person = new PersonChecklist();
        private DatabaseBLacklist database = new DatabaseBLacklist();
        private void ChecklistBTN_Click(object sender, EventArgs e)
        {
            string name = textBox1.Text;
            string id = textBox2.Text;
            string account = textBox3.Text;
            string marketAccount = textBox9.Text;
            
            //เก็บค่าเข้าไปที่ อ็อบเจ็ค person 
            person.SetName(name);
            person.SetID(id);
            person.SetAccount(account);
            person.SetMarketAccount(marketAccount);

            //เซ็ท person เป็นค่าใหม่จากฟังก์ชัน CheckList()
            person = person.CheckList(person);
            if (person.GetName() == "")
            {
                MessageBox.Show("ไม่อยู่ในรายชื่อ Blacklist Seller");
                textBox4.Text = string.Empty;
                textBox5.Text = string.Empty;
                textBox6.Text = string.Empty;
                textBox7.Text = string.Empty;
                textBox8.Text = string.Empty;
                textBox10.Text = string.Empty;
            }
            else
            {
                textBox4.Text = person.GetName();
                textBox5.Text = person.GetID();
                textBox6.Text = person.GetAccountName();
                textBox7.Text = person.GetProduct();
                textBox8.Text = person.GetMarketPlace();
                textBox10.Text = person.GetMarketAcc();
            }
        }
    }
}
