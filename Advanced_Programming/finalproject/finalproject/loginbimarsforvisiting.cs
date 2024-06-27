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
    public partial class loginbimarsforvisiting : Form
    {
        string name = "";
        string familyname = "";
        string idnumber = "";
        string folderName = @"D:\C#Files991\";
        string filenamePrefix2 = "notyetvisitedbimarsFile";
        public loginbimarsforvisiting()
        {
            InitializeComponent();
        }

        private void name_text_TextChanged(object sender, EventArgs e)
        {
            name = name_text.Text;
        }
        private void family_text_TextChanged(object sender, EventArgs e)
        {
            familyname = family_text.Text;
        }
        private void id_text_TextChanged(object sender, EventArgs e)
        {
            idnumber = id_text.Text;
        }
        private void tryagain()
        {
            name = "";
            familyname = "";
            idnumber = "";
            name_text.Text = "";
            family_text.Text = "";
            id_text.Text = "";
            canceling_chk.Checked = false;
            not_canceling_chk.Checked = false;
            canceling_chk.Visible = false;
            not_canceling_chk.Visible = false;
            label5.Visible = false;
        }

        private void check_finished_CheckedChanged(object sender, EventArgs e)
        {
            canceling_chk.Visible = true;
            not_canceling_chk.Visible = true;
            label5.Visible = true;
        }
        private void canceling_chk_CheckedChanged(object sender, EventArgs e)
        {
            var managebimar1 = new Manageformerbimar(folderName + filenamePrefix2, new SaveLoadManageformerbimar_WriteReadAll());
            managebimar1.remove_Appointment(name, familyname, idnumber);
            MessageBox.Show("نوبت شما با موفقیت لغو گردید!!");
        }

        private void not_canceling_chk_CheckedChanged(object sender, EventArgs e)
        {
            var manageformerbimar = new Manageformerbimar(folderName + filenamePrefix2, new SaveLoadManageformerbimar_WriteReadAll());
            int is_checked = manageformerbimar.checkbimar(name, familyname, idnumber);
            if (is_checked == 1)
            {
                MessageBox.Show("میتوانی به پزشک مورد نظر خود مراجعه کرد و صورتحساب را پرداخت کنی!!");
                doctorassistant monshi_form = new doctorassistant(name, familyname, idnumber);
                monshi_form.Show();
            }
            if (is_checked == 0)
            {
                MessageBox.Show("تلاش ناموفق.اطلاعات کاربری شما به عنوان بیمار اشتباه می باشد!!");
                tryagain();
                name_text.Focus();
            }
        }
    }
}
