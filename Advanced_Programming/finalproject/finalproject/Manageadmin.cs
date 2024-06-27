using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Text.Json;
using System.Xml.Serialization;

namespace finalproject
{
    [Serializable]
    class Manageadmin
    {
        public string idnumber { set; get; }
        public double salary { set; get; }
        private static string filepath = @"D:\C#Files991\" + "adminsFile" + "_" + "SaveLoadManageadmin_WriteReadAll" + ".txt";
        private static Manageadmin manageadmin=null;
        public static Manageadmin GetInstance()
        {
            if(manageadmin==null)
                manageadmin = new Manageadmin();
            return manageadmin;
        }
        public void Read_File(string filepath)
        {
            manageadmin= JsonSerializer.Deserialize<Manageadmin>(File.ReadAllText(filepath));
        }
        public void Write_File(string filepath,Manageadmin manageadmin)
        {
            File.WriteAllText(filepath, JsonSerializer.Serialize(manageadmin));
        }
        public void Addslary(double salary1)
        {
            manageadmin.salary += salary1;
            Write_File(filepath,manageadmin);
        }
        public double minussalary(double salary)
        {
            double baghimande = 0;
            manageadmin.salary -= salary;
            baghimande += manageadmin.salary;
            Write_File(filepath,manageadmin);
            return baghimande;
        }
        public void addadmin(Manageadmin manageadmin1,string filepath)
        {
            if (!File.Exists(filepath))
            {
                manageadmin1.idnumber = "10000";
                manageadmin1.salary = 0;
                manageadmin1.Write_File(filepath, manageadmin1);
            }
            else
            {
                manageadmin1.Read_File(filepath);
            }
        }
        public int Is_enough()
        {
            string folderName1 = @"D:\C#Files991\";
            string filenamePrefix1 = "assistantsFile";
            double needed_salary = 0;
            var manageassistants1 = new Manageassistants(folderName1 + filenamePrefix1, new SaveLoadManageAppointments_WriteReadAll_assistants());
            foreach (var item in manageassistants1.assistantlist)
            {
                needed_salary += item.pishfarzsalary;
            }
            if (manageadmin.salary <= needed_salary)
            {
                return 0;
            }
            else
            {
                return 1;
            }
        }
        public int checkadmin(string idnumber)
        {
            int flag = 0;
            if (manageadmin.idnumber == idnumber)
            {
                flag = 1;
            }
            if (flag == 1)
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }
    }
}
