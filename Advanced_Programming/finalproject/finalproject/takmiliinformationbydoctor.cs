using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace finalproject
{
    public partial class takmiliinformationbydoctor : Form
    {
        string information = "";
        string folderName = @"D:\C#Files991\";
        string filenamePrefix = "bimarsFile";
        string filenamePrefix3 = "notyetvisitedbimarsFile";
        string bimarname = "";
        string bimarfamilyname = "";
        string bimaridnumber = "";
        DateTime bimarfinalappointmenttime=new DateTime();
        string bimarsabeqe = "";
        string bimardoctorname = "";
        public takmiliinformationbydoctor(string name, string familyname, string idnumber,string doctorname,string savabeq)
        {
            InitializeComponent();
            bimarname = name;
            bimarfamilyname = familyname;
            bimaridnumber = idnumber;
            bimarsabeqe = savabeq;
            bimardoctorname = doctorname;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            information = "tarmim dosathi";
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            information = "tarmim sesathi";
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            information = "darmane rishe dosathi";
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            information = "darmane rishe sesathi";
        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            information = "asabkashi ba leizer";
        }

        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {
            information = "asabkashi besoorate mamooli";
        }

        private void checkBox7_CheckedChanged(object sender, EventArgs e)
        {
            information = "amalgum";
        }

        private void checkBox8_CheckedChanged(object sender, EventArgs e)
        {
            information = "composit";
        }

        private void checkBox9_CheckedChanged(object sender, EventArgs e)
        {
            bimarsabeqe = bimarsabeqe + " ( " + information+" ) ";
            var manageformerbimar = new Manageformerbimar(folderName + filenamePrefix3, new SaveLoadManageformerbimar_WriteReadAll());
            bimarfinalappointmenttime = manageformerbimar.givetheappointmenttime(bimarname, bimarfamilyname, bimaridnumber);
            var managebimars = new Managebimar(folderName + filenamePrefix, new SaveLoadManagebimar_WriteReadAll());
            var bimar10 = new bimar { name = bimarname, familyname = bimarfamilyname, idnumber = bimaridnumber, sabeqe = bimarsabeqe,doctorname=bimardoctorname, Time = bimarfinalappointmenttime };
            managebimars.Addbimar(bimar10);
            manageformerbimar.removebimar(bimarname, bimarfamilyname, bimaridnumber);
            MessageBox.Show("ویزیت بیمار مورد نظر با موفقیت انجام شد!!");
            Close();
        }
    }
}
