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
    public partial class private_monshi_form : Form
    {
        string doctorname = "";
        List<bimar> visitedBimars = new List<bimar>();
        List<former_bimar> notvisitedBimars = new List<former_bimar>();
        string folderName1 = @"D:\C#Files991\";
        string filenamePrefix = "bimarsFile";
        string filenamePrefix1 = "notyetvisitedbimarsFile";
        string filenamePrefix2 = "assistantsFile";
        string bimar_id = "";
        string assistant_new_id = "";
        public private_monshi_form(string _doctorname)
        {
            InitializeComponent();
            doctorname = _doctorname;
        }

        private void private_monshi_form_Load(object sender, EventArgs e)
        {
            assistant_name_lbl.Text = "Assistant of " + doctorname;
        }

        private void list_of_bimars_btn_Click(object sender, EventArgs e)
        {
            id_txt.Visible = false;
            id_txt.Text = "";
            bimar_id_lbl.Visible = false;
            search_btn.Visible = false;
            dataGridView2.Visible = false;
            dataGridView_listofvisitedbimars.Visible = true;
            var managebimar = new Managebimar(folderName1 + filenamePrefix, new SaveLoadManagebimar_WriteReadAll());
            visitedBimars=managebimar.searchbimar(doctorname);
            dataGridView_listofvisitedbimars.DataSource = visitedBimars;

        }
        private void search_bimar_btn_Click(object sender, EventArgs e)
        {
            dataGridView_listofvisitedbimars.Visible = false;
            dataGridView_listofnotyetvisited_bimars.Visible = false;
            id_txt.Visible = true;
            bimar_id_lbl.Visible = true;
            search_btn.Visible = true;
            id_txt.Focus();
        }

        private void id_txt_TextChanged(object sender, EventArgs e)
        {
            bimar_id = id_txt.Text;
        }

        private void search_btn_Click(object sender, EventArgs e)
        {
            dataGridView2.Visible = true;
            var managebimar = new Managebimar(folderName1 + filenamePrefix, new SaveLoadManagebimar_WriteReadAll());
            if(managebimar.Is_bimar(bimar_id, doctorname)==1)
            {
                dataGridView2.DataSource = managebimar.searachedlist;
            }
            else
            {
                MessageBox.Show("بیمار مورد نظر یافت نشد!!");
            }
        }

        private void listofnotyetvisitedbimars_btn_Click(object sender, EventArgs e)
        {
            dataGridView_listofvisitedbimars.Visible = false;
            dataGridView_listofnotyetvisited_bimars.Visible = true;
            var managebimar1 = new Manageformerbimar(folderName1 + filenamePrefix1, new SaveLoadManageformerbimar_WriteReadAll());
            notvisitedBimars = managebimar1.searchbimar(doctorname);
            dataGridView_listofnotyetvisited_bimars.DataSource = notvisitedBimars;
        }

        private void id_changed_btn_Click(object sender, EventArgs e)
        {
            dataGridView2.Visible = false;
            dataGridView_listofvisitedbimars.Visible = false;
            dataGridView_listofnotyetvisited_bimars.Visible = false;
            id_txt.Visible = false;
            bimar_id_lbl.Visible = false;
            search_btn.Visible = false;
            new_id_lbl.Visible = true;
            newid_txt.Visible = true;
            finished_lbl.Visible = true;
            finished_chk.Visible = true;
            newid_txt.Focus();
        }

        private void newid_txt_TextChanged(object sender, EventArgs e)
        {
            assistant_new_id = newid_txt.Text;
        }
        private void finished_chk_CheckedChanged(object sender, EventArgs e)
        {
            var manageassistants = new Manageassistants(folderName1 + filenamePrefix2, new SaveLoadManageAppointments_WriteReadAll_assistants());
            manageassistants.change_idnumber(doctorname, assistant_new_id);
            MessageBox.Show("رمز عبور شما با موفقیت تغییر یافت!!");
            new_id_lbl.Visible = false;
            newid_txt.Visible = false;
            finished_lbl.Visible = false;
            finished_chk.Visible = false;
        }
    }
}
