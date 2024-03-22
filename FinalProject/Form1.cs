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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ReportBlack_Click(object sender, EventArgs e)
        {
            //เปิดหน้า Form2 (หน้าแจ้งรายงานคนโกง)
            Form2 Report = new Form2();
            Report.Show();
        }

        private void CheckBlack_Click(object sender, EventArgs e)
        {
            //เปิดหน้า Form3 (หน้าตรวจสอบคนโกง)
            Form3 CheckList = new Form3();
            CheckList.Show();
        }
    }
}
