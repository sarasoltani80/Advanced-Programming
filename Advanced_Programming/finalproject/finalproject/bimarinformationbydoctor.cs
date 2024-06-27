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
    public partial class bimarinformationbydoctor : Form
    {
        string _familyname = "";
        string _idnumber = "";
        string folderName1 = @"D:\C#Files991\";
        string filenamePrefix1 = "doctorsFile";
        string bimardoctorname = "";
        string bimarname = "";
        string bimarfamilyname = "";
        string bimaridnumber = "";
        string bimarsabeqe = "";
        //doctorassistant assistantform = new doctorassistant(new bimar_form());
        //bimar_form sickform = new bimar_form();
       // public bimarinformationbyassistant assistantinformation = new bimarinformationbyassistant(new doctorassistant(new bimar_form()));
        public bimarinformationbydoctor(string name, string familyname, string idnumber,string doctorname,string savabeq)
        {
            InitializeComponent();
            bimarname = name;
            bimarfamilyname = familyname;
            bimaridnumber = idnumber;
            /*bimarfinalappointmenttime = value4;
            bimarkhadamat = value5;*/
            bimardoctorname = doctorname;
            bimarsabeqe = savabeq;
            //assistantinformation = f;
            //assistantform = f;
            
        }
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            _familyname = "dr.soltani";
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            _familyname = "dr.hoseini";
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            _familyname = "dr.mosalman";
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            _familyname = "dr.nabavi";
        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            _familyname = "dr.karimi";
        }

        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {
            _familyname = "dr.mortazavi";
        }

        private void checkBox7_CheckedChanged(object sender, EventArgs e)
        {
            _familyname = "dr.khosravi";
        }

        private void checkBox8_CheckedChanged(object sender, EventArgs e)
        {
            _familyname = "dr.eslami";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            _idnumber = textBox1.Text;
        }
        private void tryagain()
        {
            textBox1.Text = "";
            if (checkBox1.Checked == true)
            {
                checkBox1.Checked = false;
            }
            if (checkBox2.Checked == true)
            {
                checkBox2.Checked = false;
            }
            if (checkBox3.Checked == true)
            {
                checkBox3.Checked = false;
            }
            if (checkBox4.Checked == true)
            {
                checkBox4.Checked = false;
            }
            if (checkBox5.Checked == true)
            {
                checkBox5.Checked = false;
            }
            if (checkBox6.Checked == true)
            {
                checkBox6.Checked = false;
            }
            if (checkBox7.Checked == true)
            {
                checkBox7.Checked = false;
            }
            if (checkBox8.Checked == true)
            {
                checkBox8.Checked = false;
            }
            if (checkBox9.Checked == true)
            {
                checkBox9.Checked = false;
            }
            _familyname = "";
            _idnumber = "";

        }
        private void checkBox9_CheckedChanged(object sender, EventArgs e)
        {
            var managedoctors=new Managedoctors(folderName1 + filenamePrefix1, new SaveLoadManagedoctors_WriteReadAll());
            var pezeshk = new doctor { familyname = _familyname, idnumber = _idnumber };
            int x = managedoctors.checkdoctors(pezeshk,bimardoctorname);
            if(x==1)
            {
                MessageBox.Show("you logged in successfully");
                takmiliinformationbydoctor takmilform = new takmiliinformationbydoctor(bimarname,bimarfamilyname,bimaridnumber,bimardoctorname,bimarsabeqe);
                takmilform.Show();
            }
            if(x==0)
            {
                MessageBox.Show("try again!!!!");
                tryagain();
                textBox1.Focus();
            }
        }
    }
}
