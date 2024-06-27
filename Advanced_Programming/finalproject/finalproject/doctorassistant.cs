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
    public partial class doctorassistant : Form
    {
        string _name = "";
        string _familyname = "";
        string _idnumber = "";
        public string _doctorname = "";
        string folderName1 = @"D:\C#Files991\";
        string filenamePrefix1 = "assistantsFile";
        string filenamePrefix2 = "notyetvisitedbimarsFile";
        /*int IsTarmim = 0;
        int IsDarman = 0;
        int IsAsabkashi = 0;
        int IsPorkardan = 0;
        int Isbool = 0;*/
        //public bimar_form mainform = new bimar_form();
        string bimardoctorname = "";
        string bimarname = "";
        string bimarfamilyname = "";
        string bimaridnumber = "";
        DateTime bimarfinalappointmenttime;
        string bimarkhadamat = "";

        public doctorassistant(string value1,string value2,string value3)
        {
            InitializeComponent();
            bimarname = value1;
            bimarfamilyname = value2;
            bimaridnumber = value3;
            /*bimarfinalappointmenttime = value4;
            bimarkhadamat = value5;
            bimardoctorname = value6;*/
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            _name = textBox1.Text;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            _familyname = textBox2.Text;
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            _idnumber = textBox3.Text;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            _doctorname = "dr.hoseini";
            //Isbool = 1;
        }

        private void checkBox8_CheckedChanged(object sender, EventArgs e)
        {
            _doctorname = "dr.soltani";
            //Isbool = 1;
        }

        private void checkBox7_CheckedChanged(object sender, EventArgs e)
        {
            _doctorname = "dr.nabavi";
            //Isbool = 4;
        }

        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {
            _doctorname = "dr.khosravi";
            //Isbool = 3;
        }
        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            _doctorname = "dr.mosalman";
            //Isbool = 4;
        }
        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            _doctorname = "dr.mortazavi";
            //Isbool = 2;
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            _doctorname = "dr.eslami";
            //Isbool = 3;
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            _doctorname = "dr.karimi";
            //Isbool = 2;
        }
        private void tryagain()
        {
            _name = "";
            _familyname = "";
            _idnumber = "";
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            if(checkBox1.Checked==true)
            {
                checkBox1.Checked = false;
            }
            if(checkBox2.Checked==true)
            {
                checkBox2.Checked = false;
            }
            if(checkBox3.Checked==true)
            {
                checkBox3.Checked = false;
            }
            if(checkBox4.Checked==true)
            {
                checkBox4.Checked = false;
            }
            if(checkBox5.Checked==true)
            {
                checkBox5.Checked = false;
            }
            if(checkBox6.Checked==true)
            {
                checkBox6.Checked = false;
            }
            if(checkBox7.Checked==true)
            {
                checkBox7.Checked = false;
            }
            if(checkBox8.Checked==true)
            {
                checkBox8.Checked = false;
            }
            if(checkBox9.Checked==true)
            {
                checkBox9.Checked = false;
            }
        }

        private void checkBox9_CheckedChanged(object sender, EventArgs e)
        {
            var manageassistants1 = new Manageassistants(folderName1 + filenamePrefix1, new SaveLoadManageAppointments_WriteReadAll_assistants());
            var kadredarman = new assistants { name = _name, familyname = _familyname, idnumber = _idnumber, doctorname = _doctorname };
            var manageformerbimar = new Manageformerbimar(folderName1 + filenamePrefix2, new SaveLoadManageformerbimar_WriteReadAll());
            string bimardoctorname=manageformerbimar.givethenameofdoctor(bimarname, bimarfamilyname, bimaridnumber);

            int x= manageassistants1.checkassistants(kadredarman,bimardoctorname);
            if(x==1)
            {
                /*if(Isbool==1)
                {
                    IsTarmim = 1;
                }
                if(Isbool==2)
                {
                    IsDarman = 1;
                }
                if(Isbool==3)
                {
                    IsAsabkashi = 1;
                }
                if(Isbool==4)
                {
                    IsPorkardan = 1;
                }*/
                MessageBox.Show("you logged in successfully");
                bimarinformationbyassistant bimarinformation1 = new bimarinformationbyassistant(bimarname, bimarfamilyname, bimaridnumber);
                bimarinformation1.Show();

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
