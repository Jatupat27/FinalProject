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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        private DatabaseBLacklist report = new DatabaseBLacklist();
        private PersonReport person = new PersonReport();
        private void ReportBTN_Click(object sender, EventArgs e)
        {
            //เก็บค่าเข้าไปที่ อ็อบเจ็ค person
            person.SetName(textBox1.Text);
            person.SetID(textBox2.Text);
            person.SetAccount(textBox3.Text);
            person.SetProduct(textBox4.Text);
            person.SetMarketAccount(textBox5.Text);
            person.SetMarketPlace(comboBox1.Text);

            ///ทำการแจ้งรายงานคนโกง
            bool canReport = report.Report(person);

            if (canReport)
            {
                MessageBox.Show("แจ้งรายงานสำเร็จ");
            }
            else
            {
                MessageBox.Show("แจ้งรายงานไม่สำเร็จ");
            }
        }
    }
}
