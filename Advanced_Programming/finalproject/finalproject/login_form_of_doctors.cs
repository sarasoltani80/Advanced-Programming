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
    public partial class login_form_of_doctors : Form
    {
        string doctorname = "";
        string idnumber = "";
        string folderName1 = @"D:\C#Files991\";
        string filenamePrefix2 = "doctorsFile";
        public login_form_of_doctors()
        {
            InitializeComponent();
        }

        private void id_text_TextChanged(object sender, EventArgs e)
        {
            idnumber = id_text.Text;
        }
        private void tryagain()
        {
            doctorname = "";
            idnumber = "";
            id_text.Text = "";
            dreslami_chk.Checked = false;
            drhoseini_chk.Checked = false;
            drkarimi_chk.Checked = false;
            drkhosravi_chk.Checked = false;
            drmortazavi_chk.Checked = false;
            drmosalman_chk.Checked = false;
            drnabavi_chk.Checked = false;
            drsoltani_chk.Checked = false;
            finished_chk.Checked = false;
        }
        private void finished_chk_CheckedChanged(object sender, EventArgs e)
        {
            var managedoctor = new Managedoctors(folderName1 + filenamePrefix2, new SaveLoadManagedoctors_WriteReadAll());
            int Isbool = managedoctor.checked_Isdoctor(doctorname, idnumber);
            if(Isbool==1)
            {
                MessageBox.Show("you log in successfully as " + doctorname+"!!");
                doctors_private_form doctor_form = new doctors_private_form(doctorname);
                doctor_form.Show();
            }
            if(Isbool==0)
            {
                MessageBox.Show("try again!!");
                tryagain();
            }
        }

        private void drhoseini_chk_CheckedChanged(object sender, EventArgs e)
        {
            doctorname = "dr.hoseini";
        }

        private void drsoltani_chk_CheckedChanged(object sender, EventArgs e)
        {
            doctorname = "dr.soltani";
        }

        private void drkarimi_chk_CheckedChanged(object sender, EventArgs e)
        {
            doctorname = "dr.karimi";
        }

        private void drmortazavi_chk_CheckedChanged(object sender, EventArgs e)
        {
            doctorname = "dr.mortazavi";
        }

        private void dreslami_chk_CheckedChanged(object sender, EventArgs e)
        {
            doctorname = "dr.eslami";
        }

        private void drkhosravi_chk_CheckedChanged(object sender, EventArgs e)
        {
            doctorname = "dr.khosravi";
        }

        private void drnabavi_chk_CheckedChanged(object sender, EventArgs e)
        {
            doctorname = "dr.nabavi";
        }

        private void drmosalman_chk_CheckedChanged(object sender, EventArgs e)
        {
            doctorname = "dr.mosalman";
        }
    }
}
