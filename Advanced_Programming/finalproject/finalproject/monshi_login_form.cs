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
    public partial class monshi_login_form : Form
    {
        string name = "";
        string familyname = "";
        string idnumber = "";
        string doctorname = "";
        string folderName1 = @"D:\C#Files991\";
        string filenamePrefix1 = "assistantsFile";
        public monshi_login_form()
        {
            InitializeComponent();
        }

        private void name_txt_TextChanged(object sender, EventArgs e)
        {
            name = name_txt.Text;
        }

        private void familyname_txt_TextChanged(object sender, EventArgs e)
        {
            familyname = familyname_txt.Text;
        }

        private void id_txt_TextChanged(object sender, EventArgs e)
        {
            idnumber = id_txt.Text;
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

        private void dreslami_chk_CheckedChanged(object sender, EventArgs e)
        {
            doctorname = "dr.eslami";
        }

        private void drmortazavi_chk_CheckedChanged(object sender, EventArgs e)
        {
            doctorname = "dr.mortazavi";
        }

        private void drnabavi_chk_CheckedChanged(object sender, EventArgs e)
        {
            doctorname = "dr.nabavi";
        }

        private void drmosalman_chk_CheckedChanged(object sender, EventArgs e)
        {
            doctorname = "dr.mosalman";
        }

        private void drkhosravi_chk_CheckedChanged(object sender, EventArgs e)
        {
            doctorname = "dr.khosravi";
        }
        private void tryagain()
        {
            name = "";
            familyname = "";
            doctorname = "";
            idnumber = "";
            name_txt.Text = "";
            familyname_txt.Text = "";
            id_txt.Text = "";
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
            var manageassistants = new Manageassistants(folderName1 + filenamePrefix1, new SaveLoadManageAppointments_WriteReadAll_assistants());
            int Is_assistant = manageassistants.check_Isassistant(name, familyname, idnumber, doctorname);
            if(Is_assistant==1)
            {
                MessageBox.Show("شما به عنوان منشی با موفقیت وارد صفحه شخصی خود شدید!!");
                private_monshi_form mainform = new private_monshi_form(doctorname);
                mainform.Show();
            }
            else
            {
                MessageBox.Show("تلاش ناموفق!!");
                tryagain();
            }
        }
    }
}
