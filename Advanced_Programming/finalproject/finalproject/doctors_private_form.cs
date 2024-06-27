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
    public partial class doctors_private_form : Form
    {
        string doctorname = "";
        string new_id = "";
        string folderName = @"D:\C#Files991\";
        string filenamePrefix = "ApponintmentsFile";
        string filenamePrefix2 = "doctorsFile";
        public doctors_private_form(string doctorname1)
        {
            InitializeComponent();
            doctorname = doctorname1;
        }

        private void listofappointment_btn_Click(object sender, EventArgs e)
        {
            dataGridView_information.Visible = true;
            //if (doctorname == "dr.hoseini")
            //{
                var manageAppointments = new ManageAppointments(folderName + filenamePrefix + doctorname, new SaveLoadManageAppointments_WriteReadAll());
                dataGridView_information.DataSource = manageAppointments.AppointmentList;
            //}
            /*if (doctorname == "dr.soltani")
            {
                var manageAppointments = new ManageAppointments_drsoltani(folderName + filenamePrefix + doctorname, new SaveLoadManageAppointments_WriteReadAll());
                dataGridView_information.DataSource = manageAppointments.AppointmentList;

            }
            if (doctorname == "dr.karimi")
            {
                var manageAppointments = new ManageAppointments_drkarimi(folderName + filenamePrefix + doctorname, new SaveLoadManageAppointments_WriteReadAll());
                dataGridView_information.DataSource = manageAppointments.AppointmentList;
            }
            if (doctorname == "dr.mortazavi")
            {
                var manageAppointments = new ManageAppointments_drmortazavi(folderName + filenamePrefix + doctorname, new SaveLoadManageAppointments_WriteReadAll());
                dataGridView_information.DataSource = manageAppointments.AppointmentList;
            }
            if (doctorname == "dr.eslami")
            {
                var manageAppointments = new ManageAppointments_dreslami(folderName + filenamePrefix + doctorname, new SaveLoadManageAppointments_WriteReadAll());
                dataGridView_information.DataSource = manageAppointments.AppointmentList;
            }
            if (doctorname == "dr.khosravi")
            {
                var manageAppointments = new ManageAppointments_drkhosravi(folderName + filenamePrefix + doctorname, new SaveLoadManageAppointments_WriteReadAll());
                dataGridView_information.DataSource = manageAppointments.AppointmentList;
            }
            if (doctorname == "dr.nabavi")
            {
                var manageAppointments = new ManageAppointments_drnabavi(folderName + filenamePrefix + doctorname, new SaveLoadManageAppointments_WriteReadAll());
                dataGridView_information.DataSource = manageAppointments.AppointmentList;
            }
            if (doctorname == "dr.mosalman")
            {
                var manageAppointments = new ManageAppointments_drmosalman(folderName + filenamePrefix + doctorname, new SaveLoadManageAppointments_WriteReadAll());
                dataGridView_information.DataSource = manageAppointments.AppointmentList;
            }*/
        }
        private void changeid_btn_Click(object sender, EventArgs e)
        {
            label2.Visible = true;
            label3.Visible = true;
            newid_txt.Visible = true;
            checkBox1.Visible = true;
        }

        private void newid_txt_TextChanged(object sender, EventArgs e)
        {
            new_id = newid_txt.Text;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            var managedoctor = new Managedoctors(folderName + filenamePrefix2, new SaveLoadManagedoctors_WriteReadAll());
            managedoctor.change_idnumber(doctorname, new_id);
            MessageBox.Show("رمز عبور شما با موفقیت تغییر یافت :)");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dataGridView_information.Visible = true;
            //if (doctorname == "dr.hoseini")
            //{
                var manageAppointments = new ManageAppointments(folderName + filenamePrefix + doctorname, new SaveLoadManageAppointments_WriteReadAll());
                manageAppointments.sorting(manageAppointments);
                dataGridView_information.DataSource = manageAppointments.AppointmentList;
            //}
            /*if (doctorname == "dr.soltani")
            {
                var manageAppointments = new ManageAppointments_drsoltani(folderName + filenamePrefix + doctorname, new SaveLoadManageAppointments_WriteReadAll());
                manageAppointments.sorting(manageAppointments);
                dataGridView_information.DataSource = manageAppointments.AppointmentList;

            }
            if (doctorname == "dr.karimi")
            {
                var manageAppointments = new ManageAppointments_drkarimi(folderName + filenamePrefix + doctorname, new SaveLoadManageAppointments_WriteReadAll());
                manageAppointments.sorting(manageAppointments);
                dataGridView_information.DataSource = manageAppointments.AppointmentList;
            }
            if (doctorname == "dr.mortazavi")
            {
                var manageAppointments = new ManageAppointments_drmortazavi(folderName + filenamePrefix + doctorname, new SaveLoadManageAppointments_WriteReadAll());
                manageAppointments.sorting(manageAppointments);
                dataGridView_information.DataSource = manageAppointments.AppointmentList;
            }
            if (doctorname == "dr.eslami")
            {
                var manageAppointments = new ManageAppointments_dreslami(folderName + filenamePrefix + doctorname, new SaveLoadManageAppointments_WriteReadAll());
                manageAppointments.sorting(manageAppointments);
                dataGridView_information.DataSource = manageAppointments.AppointmentList;
            }
            if (doctorname == "dr.khosravi")
            {
                var manageAppointments = new ManageAppointments_drkhosravi(folderName + filenamePrefix + doctorname, new SaveLoadManageAppointments_WriteReadAll());
                manageAppointments.sorting(manageAppointments);
                dataGridView_information.DataSource = manageAppointments.AppointmentList;
            }
            if (doctorname == "dr.nabavi")
            {
                var manageAppointments = new ManageAppointments_drnabavi(folderName + filenamePrefix + doctorname, new SaveLoadManageAppointments_WriteReadAll());
                manageAppointments.sorting(manageAppointments);
                dataGridView_information.DataSource = manageAppointments.AppointmentList;
            }
            if (doctorname == "dr.mosalman")
            {
                var manageAppointments = new ManageAppointments_drmosalman(folderName + filenamePrefix + doctorname, new SaveLoadManageAppointments_WriteReadAll());
                manageAppointments.sorting(manageAppointments);
                dataGridView_information.DataSource = manageAppointments.AppointmentList;
            }*/
        }
    }
}
