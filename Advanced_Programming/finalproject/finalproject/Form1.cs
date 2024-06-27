using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace finalproject
{
    public partial class Form1 : Form
    {
        string folderName1 = @"D:\C#Files991\";
        string filenamePrefix1 = "assistantsFile";
        string filenamePrefix2 = "doctorsFile";
        string filenamePrefix3 = "sahamdaranFile";
        string filepath = @"D:\C#Files991\" + "adminsFile" + "_" + "SaveLoadManageadmin_WriteReadAll" + ".txt";
        public Form1()
        {
            InitializeComponent();
        }

        private void bimar_checked_CheckedChanged(object sender, EventArgs e)
        {
            khadamat_checked.Visible = true;
            nobatdahi_checked.Visible = true;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            var manageassistants = new Manageassistants(folderName1 + filenamePrefix1, new SaveLoadManageAppointments_WriteReadAll_assistants());
            if (manageassistants.assistantlist.Count == 0)
            {
                var monshi1 = new assistants { name = "Hamid", familyname = "Mohamadi", idnumber = "11111", doctorname = "dr.hoseini" ,salary=0,pishfarzsalary=200};
                var monshi2 = new assistants { name = "sara", familyname = "soltani", idnumber = "22222", doctorname = "dr.soltani", salary = 0, pishfarzsalary = 200 };
                var monshi3 = new assistants { name = "ali", familyname = "rezvani", idnumber = "33333", doctorname = "dr.karimi", salary = 0, pishfarzsalary = 200 };
                var monshi4 = new assistants { name = "Hamid", familyname = "hasani", idnumber = "44444", doctorname = "dr.mortazavi", salary = 0, pishfarzsalary = 200 };
                var monshi5 = new assistants { name = "zahra", familyname = "mozafari", idnumber = "55555", doctorname = "dr.eslami", salary = 0, pishfarzsalary = 200 };
                var monshi6 = new assistants { name = "raha", familyname = "Mohamadi", idnumber = "66666", doctorname = "dr.khosravi", salary = 0, pishfarzsalary = 200 };
                var monshi7 = new assistants { name = "zahra", familyname = "Mohamadi", idnumber = "77777", doctorname = "dr.nabavi", salary = 0, pishfarzsalary = 200 };
                var monshi8 = new assistants { name = "mahdi", familyname = "Mohamadi", idnumber = "88888", doctorname = "dr.mosalman", salary = 0, pishfarzsalary = 200 };
                manageassistants.Addassistants(monshi1);
                manageassistants.Addassistants(monshi2);
                manageassistants.Addassistants(monshi3);
                manageassistants.Addassistants(monshi4);
                manageassistants.Addassistants(monshi5);
                manageassistants.Addassistants(monshi6);
                manageassistants.Addassistants(monshi7);
                manageassistants.Addassistants(monshi8);
            }
            var managedoctor = new Managedoctors(folderName1 + filenamePrefix2, new SaveLoadManagedoctors_WriteReadAll());
            if (managedoctor.doctorlist.Count == 0)
            {
                var pezeshk1 = new doctor { familyname = "dr.hoseini", idnumber = "11111", darsadsahm = 20 };
                var pezeshk2 = new doctor { familyname = "dr.soltani", idnumber = "22222" };
                var pezeshk3 = new doctor { familyname = "dr.karimi", idnumber = "33333" };
                var pezeshk4 = new doctor { familyname = "dr.mortazavi", idnumber = "44444" };
                var pezeshk5 = new doctor { familyname = "dr.eslami", idnumber = "55555", darsadsahm = 30 };
                var pezeshk6 = new doctor { familyname = "dr.khosravi", idnumber = "66666" };
                var pezeshk7 = new doctor { familyname = "dr.nabavi", idnumber = "77777" };
                var pezeshk8 = new doctor { familyname = "dr.mosalman", idnumber = "88888" };
                managedoctor.Adddoctors(pezeshk1);
                managedoctor.Adddoctors(pezeshk2);
                managedoctor.Adddoctors(pezeshk3);
                managedoctor.Adddoctors(pezeshk4);
                managedoctor.Adddoctors(pezeshk5);
                managedoctor.Adddoctors(pezeshk6);
                managedoctor.Adddoctors(pezeshk7);
                managedoctor.Adddoctors(pezeshk8);
            }
            var managesahamdar = new Managesahamdaran(folderName1 + filenamePrefix3, new SaveLoadManagesahamdaran_WriteReadAll());
            if (managesahamdar.sahamdarList.Count == 0)
            {
                var sahamdar1 = new sahamdar { idnumber = "11111", darsadsahm = 10 };
                var sahamdar2 = new sahamdar { idnumber = "55555", darsadsahm = 30 };
                var sahamdar3 = new sahamdar { idnumber = "66666", darsadsahm = 25 };
                var sahamdar4 = new sahamdar { idnumber = "77777", darsadsahm = 25 };
                managesahamdar.Addsahamdar(sahamdar1);
                managesahamdar.Addsahamdar(sahamdar2);
                managesahamdar.Addsahamdar(sahamdar3);
                managesahamdar.Addsahamdar(sahamdar4);
            }
            Manageadmin manageadmin1 = Manageadmin.GetInstance();
            manageadmin1.addadmin(manageadmin1, filepath);
        }

        private void admin_checked_CheckedChanged(object sender, EventArgs e)
        {
            adminloginform adminform = new adminloginform();
            adminform.Show();
        }

        private void kadredarman_checked_CheckedChanged(object sender, EventArgs e)
        {
            monshi_login_form monshi_form = new monshi_login_form();
            monshi_form.Show();
        }

        private void nobatdahi_checked_CheckedChanged(object sender, EventArgs e)
        {
            bimar_form bimarform = new bimar_form();
            bimarform.Show(this);
        }

        private void khadamat_checked_CheckedChanged(object sender, EventArgs e)
        {
            loginbimarsforvisiting loginbimar_form = new loginbimarsforvisiting();
            loginbimar_form.Show(this);
        }

        private void doctor_checked_CheckedChanged(object sender, EventArgs e)
        {
            login_form_of_doctors login_form = new login_form_of_doctors();
            login_form.Show();
        }
    }
}
