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
    public partial class adminform : Form
    {
        string folderName1 = @"D:\C#Files991\";
        string filenamePrefix1 = "assistantsFile";
        string filenamePrefix2 = "doctorsFile";
        string filenamePrefix3 = "sahamdaranFile";
        string filenamePrefix4 = "adminsFile";
        string filenamePrefix = "bimarsFile";
        public adminform()
        {
            InitializeComponent();
        }

        private void btn_visitdoctors_Click(object sender, EventArgs e)
        {
            var managedoctor = new Managedoctors(folderName1 + filenamePrefix2, new SaveLoadManagedoctors_WriteReadAll());
            datagridviewdoctors.DataSource = managedoctor.doctorlist;
        }

        private void btn_visitbimar_Click(object sender, EventArgs e)
        {
            var managebimars = new Managebimar(folderName1 + filenamePrefix, new SaveLoadManagebimar_WriteReadAll());
            datagridviewdoctors.DataSource = managebimars.visitedbimarList;
        }

        private void btn_visitassistant_Click(object sender, EventArgs e)
        {
            var manageassistants = new Manageassistants(folderName1 + filenamePrefix1, new SaveLoadManageAppointments_WriteReadAll_assistants());
            datagridviewdoctors.DataSource = manageassistants.assistantlist;
        }

        private void btn_visitsahamdar_Click(object sender, EventArgs e)
        {
            var managesahamdar = new Managesahamdaran(folderName1 + filenamePrefix3, new SaveLoadManagesahamdaran_WriteReadAll());
            datagridviewdoctors.DataSource = managesahamdar.sahamdarList;
        }
    }
}
