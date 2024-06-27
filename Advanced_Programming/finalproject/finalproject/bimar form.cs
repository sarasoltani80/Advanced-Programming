using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;

namespace finalproject
{
    public partial class bimar_form : Form
    {
        string name = "";
        string familyname = "";
        string idnumber = "";
        string dayofweek;
        int dayplus;
        DateTime appointmenttime;
        DateTime finalappointmenttime;
        string IsMahdood = "";
        string doctorname = "";
        int numberofteeth;
        string folderName = @"D:\C#Files991\";
        string filenamePrefix = "ApponintmentsFile";
        string filenamePrefix1 = "showpossibleappointmentsFile";
        string filenamePrefix2 = "notyetvisitedbimarsFile";
        string filenamePrefix3 = "bimarsFile";
        public bimar_form()
        {
            InitializeComponent();
        }

        private void txt_name_TextChanged(object sender, EventArgs e)
        {
            name = txt_name.Text;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            label5.Visible = true;
            checkBox5.Visible = true;
            checkBox6.Visible = true;
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            var managebimars = new Managebimar(folderName + filenamePrefix3, new SaveLoadManagebimar_WriteReadAll());
            string Is_takmil = managebimars.Is_takmili_by_doctor(name, familyname, idnumber);
            if (Is_takmil == "0")
            {
                label6.Visible = true;
                checkBox7.Visible = true;
                checkBox8.Visible = true;
            }
            else
            {
                if (Is_takmil == "dr.karimi")
                    checkBox7.Visible = true;
                if (Is_takmil == "dr.mortazavi")
                    checkBox8.Visible = true;
            }
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            label7.Visible = true;
            checkBox10.Visible = true;
            checkBox9.Visible = true;
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            label8.Visible = true;
            checkBox12.Visible = true;
            checkBox11.Visible = true;
        }

        private void txt_familyname_TextChanged(object sender, EventArgs e)
        {
            familyname = txt_familyname.Text;
        }

        private void txt_idnumber_TextChanged(object sender, EventArgs e)
        {
            idnumber = txt_idnumber.Text;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            dayplus = Convert.ToInt32(textBox1.Text);
        }

        private void checkBox15_CheckedChanged(object sender, EventArgs e)
        {
            dayofweek = "zoj";
        }

        private void checkBox14_CheckedChanged(object sender, EventArgs e)
        {
            dayofweek = "fard";
        }
        private void checkBox13_CheckedChanged(object sender, EventArgs e)
        {
            dayofweek = "none";
        }
        private void checkBox16_CheckedChanged(object sender, EventArgs e)
        {
            DateTime localDate = DateTime.Now;
            String[] cultureNames = { "en-US", "en-GB", "fr-FR",
                                "de-DE", "ru-RU" };
            var culture = new CultureInfo(cultureNames[1]);
            string date = localDate.ToString(culture);
            string[] tokens = date.Split();
            string time = tokens[0];
            appointmenttime = Convert.ToDateTime(time);
            appointmenttime=appointmenttime.AddDays(dayplus);
            if(appointmenttime.DayOfWeek==DayOfWeek.Thursday)
            {
                appointmenttime = appointmenttime.AddDays(2);
            }
            if(appointmenttime.DayOfWeek==DayOfWeek.Friday)
            {
                appointmenttime = appointmenttime.AddDays(1);
            }
            if(dayofweek=="zoj"&&(appointmenttime.DayOfWeek==DayOfWeek.Sunday||appointmenttime.DayOfWeek==DayOfWeek.Tuesday))
            {
                appointmenttime = appointmenttime.AddDays(1);
            }
            if(dayofweek=="fard"&&(appointmenttime.DayOfWeek==DayOfWeek.Saturday||appointmenttime.DayOfWeek==DayOfWeek.Monday))
            {
                appointmenttime = appointmenttime.AddDays(1);
            }
            if(dayofweek=="fard"&&appointmenttime.DayOfWeek==DayOfWeek.Wednesday)
            {
                appointmenttime = appointmenttime.AddDays(4);
            }
            //if (doctorname == "dr.hoseini")
            //{
                var manageAppointments = new ManageAppointments(folderName + filenamePrefix + doctorname, new SaveLoadManageAppointments_WriteReadAll());
                var appointment2 = new Appointment_drhoseini { Time = appointmenttime };
                var manage = new ManageAppointments(appointment2.Time, folderName + filenamePrefix1+doctorname, new SaveLoadManagedatetimesdrhoseini_WriteReadAll());
                finalappointmenttime = manageAppointments.finaltime(manageAppointments, manage, appointment2, IsMahdood, dayofweek, numberofteeth);
                MessageBox.Show(finalappointmenttime + "  has set for you succesfully!!");
            //}
            /*if (doctorname == "dr.soltani")
            {
                var manageAppointments = new ManageAppointments(folderName + filenamePrefix + doctorname, new SaveLoadManageAppointments_WriteReadAll());
                var appointment2 = new Appointment_drhoseini { Time = appointmenttime };
                var manage = new ManageAppointments(appointment2.Time, folderName + filenamePrefix1+doctorname, new SaveLoadManagedatetimesdrhoseini_WriteReadAll());
                finalappointmenttime = manageAppointments.finaltime(manageAppointments, manage, appointment2, IsMahdood, dayofweek, numberofteeth);
                MessageBox.Show(finalappointmenttime + "  has set for you succesfully!!");
            }
            if (doctorname == "dr.karimi")
            {
                var manageAppointments = new ManageAppointments(folderName + filenamePrefix + doctorname, new SaveLoadManageAppointments_WriteReadAll());
                var appointment2 = new Appointment_drhoseini { Time = appointmenttime };
                var manage = new ManageAppointments(appointment2.Time, folderName + filenamePrefix1 + doctorname, new SaveLoadManagedatetimesdrhoseini_WriteReadAll());
                finalappointmenttime = manageAppointments.finaltime(manageAppointments, manage, appointment2, IsMahdood, dayofweek, numberofteeth);
                MessageBox.Show(finalappointmenttime + "  has set for you succesfully!!");
            }
            if (doctorname == "dr.mortazavi")
            {
                var manageAppointments = new ManageAppointments(folderName + filenamePrefix + doctorname, new SaveLoadManageAppointments_WriteReadAll());
                var appointment2 = new Appointment_drhoseini { Time = appointmenttime };
                var manage = new ManageAppointments(appointment2.Time, folderName + filenamePrefix1 + doctorname, new SaveLoadManagedatetimesdrhoseini_WriteReadAll());
                finalappointmenttime = manageAppointments.finaltime(manageAppointments, manage, appointment2, IsMahdood, dayofweek, numberofteeth);
                MessageBox.Show(finalappointmenttime + "  has set for you succesfully!!");
            }
            if (doctorname == "dr.eslami")
            {
                var manageAppointments = new ManageAppointments(folderName + filenamePrefix + doctorname, new SaveLoadManageAppointments_WriteReadAll());
                var appointment2 = new Appointment_drhoseini { Time = appointmenttime };
                var manage = new ManageAppointments(appointment2.Time, folderName + filenamePrefix1 + doctorname, new SaveLoadManagedatetimesdrhoseini_WriteReadAll());
                finalappointmenttime = manageAppointments.finaltime(manageAppointments, manage, appointment2, IsMahdood, dayofweek, numberofteeth);
                MessageBox.Show(finalappointmenttime + "  has set for you succesfully!!");
            }
            if (doctorname == "dr.khosravi")
            {
                var manageAppointments = new ManageAppointments(folderName + filenamePrefix + doctorname, new SaveLoadManageAppointments_WriteReadAll());
                var appointment2 = new Appointment_drhoseini{ Time = appointmenttime };
                var manage = new ManageAppointments(appointment2.Time, folderName + filenamePrefix1 + doctorname, new SaveLoadManagedatetimesdrhoseini_WriteReadAll());
                finalappointmenttime = manageAppointments.finaltime(manageAppointments, manage, appointment2, IsMahdood, dayofweek, numberofteeth);
                MessageBox.Show(finalappointmenttime + "  has set for you succesfully!!");
            }
            if (doctorname == "dr.nabavi")
            {
                var manageAppointments = new ManageAppointments(folderName + filenamePrefix + doctorname, new SaveLoadManageAppointments_WriteReadAll());
                var appointment2 = new Appointment_drhoseini { Time = appointmenttime };
                var manage = new ManageAppointments(appointment2.Time, folderName + filenamePrefix1 + doctorname, new SaveLoadManagedatetimesdrhoseini_WriteReadAll());
                finalappointmenttime = manageAppointments.finaltime(manageAppointments, manage, appointment2, IsMahdood, dayofweek, numberofteeth);
                MessageBox.Show(finalappointmenttime + "  has set for you succesfully!!");
            }
            if (doctorname == "dr.mosalman")
            {
                var manageAppointments = new ManageAppointments(folderName + filenamePrefix + doctorname, new SaveLoadManageAppointments_WriteReadAll());
                var appointment2 = new Appointment_drhoseini { Time = appointmenttime };
                var manage = new ManageAppointments(appointment2.Time, folderName + filenamePrefix1 + doctorname, new SaveLoadManagedatetimesdrhoseini_WriteReadAll());
                finalappointmenttime = manageAppointments.finaltime(manageAppointments, manage, appointment2, IsMahdood, dayofweek, numberofteeth);
                MessageBox.Show(finalappointmenttime + "  has set for you succesfully!!");
            }*/
            var manageformerbimar = new Manageformerbimar(folderName + filenamePrefix2, new SaveLoadManageformerbimar_WriteReadAll());
            var formerbimar = new former_bimar { name = name, familyname = familyname, idnumber = idnumber, doctorname = doctorname,tedaddandan=numberofteeth, Time = finalappointmenttime };
            manageformerbimar.Addnewbimar(formerbimar);
        }
        private void yes_check_CheckedChanged(object sender, EventArgs e)
        {
            label13.Visible = true;
            //checkBox17.Visible = true;
            //checkBox18.Visible = true;
            checkBox19.Visible = true;
            checkBox20.Visible = true;
        }
        private void no_check_CheckedChanged(object sender, EventArgs e)
        {
            IsMahdood = "0";
        }

        private void checkBox20_CheckedChanged(object sender, EventArgs e)
        {
            IsMahdood = "1";
        }

        private void checkBox19_CheckedChanged(object sender, EventArgs e)
        {
            IsMahdood = "2";
        }

        private void checkBox18_CheckedChanged(object sender, EventArgs e)
        {
            IsMahdood = "3";
        }

        private void checkBox17_CheckedChanged(object sender, EventArgs e)
        {
            IsMahdood = "4";
        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            doctorname = "dr.hoseini";
        }

        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {
            doctorname = "dr.soltani";
        }

        private void checkBox7_CheckedChanged(object sender, EventArgs e)
        {
            doctorname = "dr.karimi";
        }

        private void checkBox8_CheckedChanged(object sender, EventArgs e)
        {
            doctorname = "dr.mortazavi";
        }

        private void checkBox10_CheckedChanged(object sender, EventArgs e)
        {
            doctorname = "dr.eslami";
        }

        private void checkBox9_CheckedChanged(object sender, EventArgs e)
        {
            doctorname = "dr.khosravi";
        }

        private void checkBox12_CheckedChanged(object sender, EventArgs e)
        {
            doctorname = "dr.nabavi";
        }

        private void checkBox11_CheckedChanged(object sender, EventArgs e)
        {
            doctorname = "dr.mosalman";
        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            numberofteeth = Convert.ToInt32(textBox2.Text);
        }
    }
}
