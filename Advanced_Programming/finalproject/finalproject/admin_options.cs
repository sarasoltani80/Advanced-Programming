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
    public partial class admin_options : Form
    {
        List<string> doctorname = new List<string>();
        int newsalary;
        string folderName1 = @"D:\C#Files991\";
        string filenamePrefix1 = "assistantsFile";
        string filenamePrefix3 = "sahamdaranFile";
        public admin_options()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            adminform mainform = new adminform();
            mainform.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label1.Visible = true;
            label2.Visible = true;
            drhoseini_checked.Visible = true;
            drsoltani_checked.Visible = true;
            drkhosravi_checked.Visible = true;
            drmortazavi_checked.Visible = true;
            dreslami_checked.Visible = true;
            drnabavi_checked.Visible = true;
            drmosalman_checked.Visible = true;
            drkarimi_checked.Visible = true;
            label3.Visible = true;
            textBox1.Visible = true;
            label4.Visible = true;
            finish_checked.Visible = true;
        }

        private void drhoseini_checked_CheckedChanged(object sender, EventArgs e)
        {
            string name = "dr.hoseini";
            doctorname.Add(name);
        }

        private void drsoltani_checked_CheckedChanged(object sender, EventArgs e)
        {
            string name = "dr.soltani";
            doctorname.Add(name);
        }

        private void dreslami_checked_CheckedChanged(object sender, EventArgs e)
        {
            string name = "dr.eslami";
            doctorname.Add(name);
        }

        private void drkhosravi_checked_CheckedChanged(object sender, EventArgs e)
        {
            string name = "dr.khosravi";
            doctorname.Add(name);
        }

        private void drmortazavi_checked_CheckedChanged(object sender, EventArgs e)
        {
            string name = "dr.mortazavi";
            doctorname.Add(name);
        }

        private void drnabavi_checked_CheckedChanged(object sender, EventArgs e)
        {
            string name = "dr.nabavi";
            doctorname.Add(name);
        }

        private void drmosalman_checked_CheckedChanged(object sender, EventArgs e)
        {
            string name = "dr.mosalman";
            doctorname.Add(name);
        }

        private void drkarimi_checked_CheckedChanged(object sender, EventArgs e)
        {
            string name = "dr.karimi";
            doctorname.Add(name);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            newsalary = Convert.ToInt32(textBox1.Text);
        }
        private void finish_checked_CheckedChanged(object sender, EventArgs e)
        {
            var manageassistants = new Manageassistants(folderName1 + filenamePrefix1, new SaveLoadManageAppointments_WriteReadAll_assistants());
            manageassistants.changesalary(doctorname, newsalary);
            MessageBox.Show("افزایش حقوق منشیان با موفقیت انجام شد");

        }

        private void btn_changedarsad_Click(object sender, EventArgs e)
        {
            change_the_darsad_of_sahamdaran change_darsad = new change_the_darsad_of_sahamdaran();
            change_darsad.Show();
        }

        private void addsalary_btn_Click(object sender, EventArgs e)
        {
            Manageadmin manageadmin2 = Manageadmin.GetInstance();
            int Is_enough = manageadmin2.Is_enough();
            if (Is_enough == 0)
            {
                MessageBox.Show("موجودی خساب شما برای پرداخت حقوق کارکنان کافی نمی باشد.");
            }
            else
            {
                var manageassistants1 = new Manageassistants(folderName1 + filenamePrefix1, new SaveLoadManageAppointments_WriteReadAll_assistants());
                double salary = manageassistants1.Addsalary();
                var managesahamdar = new Managesahamdaran(folderName1 + filenamePrefix3, new SaveLoadManagesahamdaran_WriteReadAll());
                double baghimande = manageadmin2.minussalary(salary);
                double salary1 = managesahamdar.Addsalary(baghimande);
                double baghimande1 = manageadmin2.minussalary(salary1);
                MessageBox.Show("حقوق منشیان و سهامداران با موفقیت پرداخت شد!!");
            }
        }
    }
}
