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
    public partial class bimarinformationbyassistant : Form
    {
        int numberofteeth;
        int hazine;
        string sabeqe1 = "";
        string folderName = @"D:\C#Files991\";
        string filenamePrefix = "bimarsFile";
        string filenamePrefix1 = "doctorsFile";
        string filenamePrefix2 = "adminsFile";
        string filenamePrefix3 = "notyetvisitedbimarsFile";
        int finalmoney;
        int Isoperate = 0;
        string bimardoctorname = "";
        string bimarname = "";
        string bimarfamilyname = "";
        string bimaridnumber = "";
        DateTime bimarfinalappointmenttime=new DateTime();
        string bimarkhadamat = "";
        //public doctorassistant doctorassistantform = new doctorassistant(new bimar_form());
        //bimar_form _bimar = new bimar_form();
        public bimarinformationbyassistant(string value1, string value2, string value3)
        {
            InitializeComponent();
            bimarname = value1;
            bimarfamilyname = value2;
            bimaridnumber = value3;
            /*bimarfinalappointmenttime = value4;
            bimarkhadamat = value5;
            bimardoctorname = value6;
            //doctorassistantform = f1;
            //doctorassistantform = f;*/
            
        }
        //public bimarinformationbyassistant()
        //{
            //InitializeComponent();
        //}
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            hazine = 20;
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            hazine = 30;
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            hazine = 40;
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            hazine = 50;
        }
        private void giveinformation(string bimarname,string bimarfamilyname,string bimaridnumber)
        {
            var manageformerbimar = new Manageformerbimar(folderName + filenamePrefix3, new SaveLoadManageformerbimar_WriteReadAll());
            bimardoctorname = manageformerbimar.givethenameofdoctor(bimarname, bimarfamilyname, bimaridnumber);
            numberofteeth = manageformerbimar.givethenumberofteeth(bimarname, bimarfamilyname, bimaridnumber);
            bimarfinalappointmenttime = manageformerbimar.givetheappointmenttime(bimarname, bimarfamilyname, bimaridnumber);
            if(bimardoctorname=="dr.hoseini"||bimardoctorname=="dr.soltani")
            {
                bimarkhadamat = "tarmim";
            }
            if(bimardoctorname=="dr.karimi"||bimardoctorname=="dr.mortazavi")
            {
                bimarkhadamat = "darmane rishe";
            }
            if(bimardoctorname=="dr.eslami"||bimardoctorname=="dr.khosravi")
            {
                bimarkhadamat = "asabkashi";
            }
            if (bimardoctorname == "dr.nabavi" || bimardoctorname == "dr.mosalman") 
            {
                bimarkhadamat = "porkardan";
            }
            sabeqe1 = bimarkhadamat + " " + numberofteeth + " teeth ";
        }
        private void calculatemoney(string bimarkhadamat,int hazine,int numberofteeth)
        {
            if (bimarkhadamat == "tarmim")
            {
                finalmoney = (numberofteeth * 600) - hazine;
            }
            if (bimarkhadamat == "darmane rishe")
            {
                finalmoney = (numberofteeth * 800) - hazine;
            }
            if (bimarkhadamat == "asabkashi")
            {
                finalmoney = (numberofteeth * 900) - hazine;
            }
            if (bimarkhadamat == "porkardan")
            {
                finalmoney = (numberofteeth * 1000) - hazine;
            }
            var managedoctors = new Managedoctors(folderName + filenamePrefix1, new SaveLoadManagedoctors_WriteReadAll());
            managedoctors.Addsalary(bimardoctorname, finalmoney / 2);
            //var manageadmin = new Manageadmin(folderName + filenamePrefix2, new SaveLoadManageadmin_WriteReadAll());
            Manageadmin manageadmin4 = Manageadmin.GetInstance();
            manageadmin4.Addslary(finalmoney / 2);
        }

        private void checkBox7_CheckedChanged(object sender, EventArgs e)
        {
            giveinformation(bimarname, bimarfamilyname, bimaridnumber);
            calculatemoney(bimarkhadamat, hazine, numberofteeth);
            if (Isoperate == 0)
            {
                var managebimars = new Managebimar(folderName + filenamePrefix, new SaveLoadManagebimar_WriteReadAll());
                var manageformerbimar = new Manageformerbimar(folderName + filenamePrefix3, new SaveLoadManageformerbimar_WriteReadAll());
                var bimar1 = new bimar { name = bimarname, familyname = bimarfamilyname, idnumber = bimaridnumber, sabeqe = sabeqe1,doctorname=bimardoctorname, Time = bimarfinalappointmenttime };
                managebimars.Addbimar(bimar1);
                manageformerbimar.removebimar(bimarname, bimarfamilyname, bimaridnumber);
                MessageBox.Show(finalmoney / 2 + " dollars you have to pay :)");
                Close();
            }
            if (Isoperate==1)
            {
                MessageBox.Show(finalmoney / 2 + " dollars you have to pay :)");
                bimarinformationbydoctor doctorform = new bimarinformationbydoctor(bimarname, bimarfamilyname, bimaridnumber,bimardoctorname,sabeqe1);
                doctorform.Show();
            }

        }
        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            Isoperate = 1;
        }
    }
}
