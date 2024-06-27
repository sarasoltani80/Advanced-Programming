using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace finalproject
{
    class Manageformerbimar
    {
        private readonly string _filePath;
        public List<former_bimar> notvisitedbimarList { get; set; }
        private readonly ISaveLoadManageformerbimar _saveLoader;
        public Manageformerbimar(string filename, ISaveLoadManageformerbimar saveLoader)
        {
            _saveLoader = saveLoader;
            _filePath = filename + "_" + _saveLoader.GetType().Name + ".txt";
            notvisitedbimarList = new List<former_bimar>();
            if (!File.Exists(_filePath))
                File.Create(_filePath).Close();
            else
                notvisitedbimarList = _saveLoader.ReadListFromFile(_filePath);
        }
        public void Addnewbimar(former_bimar appointment)
        {
            notvisitedbimarList.Add(appointment);
            _saveLoader.SaveListToFile(_filePath, notvisitedbimarList);
        }
        public void removebimar(string name, string familyname, string idnumber)
        {
            for (int x=0;x<notvisitedbimarList.Count;x++)
            {
                if (notvisitedbimarList[x].name == name && notvisitedbimarList[x].familyname == familyname && notvisitedbimarList[x].idnumber == idnumber)
                {
                    notvisitedbimarList.Remove(notvisitedbimarList[x]);
                    _saveLoader.SaveListToFile(_filePath, notvisitedbimarList);
                    return;
                }
            }
        }
        public int checkbimar(string name,string family,string id)
        {
            int flag= 0;
            foreach(var item in notvisitedbimarList)
            {
                if(item.name==name&&item.familyname==family&&item.idnumber==id)
                {
                    flag = 1;
                }
            }
            if(flag==0)
            {
                return 0;
            }
            else
            {
                return 1;
            }
        }
        public string givethenameofdoctor(string name,string familyname,string id)
        {
            string doctorname = "";
            foreach(var item in notvisitedbimarList)
            {
                if(item.name==name&&item.familyname==familyname&&item.idnumber==id)
                {
                    doctorname = item.doctorname;
                }
            }
            return doctorname;
        }
        public int givethenumberofteeth(string name,string familyname,string idnumber)
        {
            int numberofteeth = 0;
            foreach (var item in notvisitedbimarList)
            {
                if (item.name == name && item.familyname == familyname && item.idnumber == idnumber)
                {
                    numberofteeth = item.tedaddandan;
                }
            }
            return numberofteeth;
        }
        public DateTime givetheappointmenttime(string name, string familyname, string idnumber)
        {
            DateTime finalappointment=new DateTime();
            foreach (var item in notvisitedbimarList)
            {
                if (item.name == name && item.familyname == familyname && item.idnumber == idnumber)
                {
                    finalappointment = item.Time;
                }
            }
            return finalappointment;
        }
        public List<former_bimar> searchbimar(string doctorname)
        {
            List<former_bimar> searchedbimarList = new List<former_bimar>();
            foreach(var item in notvisitedbimarList)
            {
                if(item.doctorname==doctorname)
                {
                    searchedbimarList.Add(item);
                }
            }
            return searchedbimarList;
        }
        public void remove_Appointment(string name,string familyname,string idnumber)
        {
            string folderName = @"D:\C#Files991\";
            string filenamePrefix = "ApponintmentsFile";
            string filenamePrefix1 = "showpossibleappointmentsFile";
            foreach (var item in notvisitedbimarList)
            {
                if(item.name==name&&item.familyname==familyname&&item.idnumber==idnumber)
                {
                    //if(item.doctorname=="dr.hoseini")
                    //{
                        DateTime date = new DateTime();
                        var manageAppointments = new ManageAppointments(folderName + filenamePrefix + item.doctorname, new SaveLoadManageAppointments_WriteReadAll());
                        var manage = new ManageAppointments(date, folderName + filenamePrefix1 + item.doctorname, new SaveLoadManagedatetimesdrhoseini_WriteReadAll());
                        manageAppointments.cancel_fromAppointmentsList(item.Time, item.tedaddandan);
                        manage.Add_to_DateList(item.Time, item.tedaddandan);
                        notvisitedbimarList.Remove(item);
                        _saveLoader.SaveListToFile(_filePath, notvisitedbimarList);
                        return;
                    //}
                    /*if(item.doctorname=="dr.soltani")
                    {
                        DateTime date = new DateTime();
                        var manageAppointments = new ManageAppointments_drsoltani(folderName + filenamePrefix + item.doctorname, new SaveLoadManageAppointments_WriteReadAll());
                        var manage = new ManageAppointments_drsoltani(date, folderName + filenamePrefix1 + item.doctorname, new SaveLoadManagedatetimesdrhoseini_WriteReadAll());
                        manageAppointments.cancel_fromAppointmentsList(item.Time, item.tedaddandan);
                        manage.Add_to_DateList(item.Time, item.tedaddandan);
                        notvisitedbimarList.Remove(item);
                        _saveLoader.SaveListToFile(_filePath, notvisitedbimarList);
                        return;
                    }
                    if(item.doctorname=="dr.karimi")
                    {
                        DateTime date = new DateTime();
                        var manageAppointments = new ManageAppointments_drkarimi(folderName + filenamePrefix + item.doctorname, new SaveLoadManageAppointments_WriteReadAll());
                        var manage = new ManageAppointments_drkarimi(date, folderName + filenamePrefix1 + item.doctorname, new SaveLoadManagedatetimesdrhoseini_WriteReadAll());
                        manageAppointments.cancel_fromAppointmentsList(item.Time, item.tedaddandan);
                        manage.Add_to_DateList(item.Time, item.tedaddandan);
                        notvisitedbimarList.Remove(item);
                        _saveLoader.SaveListToFile(_filePath, notvisitedbimarList);
                        return;
                    }
                    if(item.doctorname=="dr.eslami")
                    {
                        DateTime date = new DateTime();
                        var manageAppointments = new ManageAppointments_dreslami(folderName + filenamePrefix + item.doctorname, new SaveLoadManageAppointments_WriteReadAll());
                        var manage = new ManageAppointments_dreslami(date, folderName + filenamePrefix1 + item.doctorname, new SaveLoadManagedatetimesdrhoseini_WriteReadAll());
                        manageAppointments.cancel_fromAppointmentsList(item.Time, item.tedaddandan);
                        manage.Add_to_DateList(item.Time, item.tedaddandan);
                        notvisitedbimarList.Remove(item);
                        _saveLoader.SaveListToFile(_filePath, notvisitedbimarList);
                        return;
                    }
                    if(item.doctorname=="dr.khosravi")
                    {
                        DateTime date = new DateTime();
                        var manageAppointments = new ManageAppointments_drkhosravi(folderName + filenamePrefix + item.doctorname, new SaveLoadManageAppointments_WriteReadAll());
                        var manage = new ManageAppointments_drkhosravi(date, folderName + filenamePrefix1 + item.doctorname, new SaveLoadManagedatetimesdrhoseini_WriteReadAll());
                        manageAppointments.cancel_fromAppointmentsList(item.Time, item.tedaddandan);
                        manage.Add_to_DateList(item.Time, item.tedaddandan);
                        notvisitedbimarList.Remove(item);
                        _saveLoader.SaveListToFile(_filePath, notvisitedbimarList);
                        return;
                    }
                    if(item.doctorname=="dr.mortazavi")
                    {
                        DateTime date = new DateTime();
                        var manageAppointments = new ManageAppointments_drmortazavi(folderName + filenamePrefix + item.doctorname, new SaveLoadManageAppointments_WriteReadAll());
                        var manage = new ManageAppointments_drmortazavi(date, folderName + filenamePrefix1 + item.doctorname, new SaveLoadManagedatetimesdrhoseini_WriteReadAll());
                        manageAppointments.cancel_fromAppointmentsList(item.Time, item.tedaddandan);
                        manage.Add_to_DateList(item.Time, item.tedaddandan);
                        notvisitedbimarList.Remove(item);
                        _saveLoader.SaveListToFile(_filePath, notvisitedbimarList);
                        return;
                    }
                    if(item.doctorname=="dr.nabavi")
                    {
                        DateTime date = new DateTime();
                        var manageAppointments = new ManageAppointments_drnabavi(folderName + filenamePrefix + item.doctorname, new SaveLoadManageAppointments_WriteReadAll());
                        var manage = new ManageAppointments_drnabavi(date, folderName + filenamePrefix1 + item.doctorname, new SaveLoadManagedatetimesdrhoseini_WriteReadAll());
                        manageAppointments.cancel_fromAppointmentsList(item.Time, item.tedaddandan);
                        manage.Add_to_DateList(item.Time, item.tedaddandan);
                        notvisitedbimarList.Remove(item);
                        _saveLoader.SaveListToFile(_filePath, notvisitedbimarList);
                        return;
                    }
                    if(item.doctorname=="dr.mosalman")
                    {
                        DateTime date = new DateTime();
                        var manageAppointments = new ManageAppointments_drmosalman(folderName + filenamePrefix + item.doctorname, new SaveLoadManageAppointments_WriteReadAll());
                        var manage = new ManageAppointments_drmosalman(date, folderName + filenamePrefix1 + item.doctorname, new SaveLoadManagedatetimesdrhoseini_WriteReadAll());
                        manageAppointments.cancel_fromAppointmentsList(item.Time, item.tedaddandan);
                        manage.Add_to_DateList(item.Time, item.tedaddandan);
                        notvisitedbimarList.Remove(item);
                        _saveLoader.SaveListToFile(_filePath, notvisitedbimarList);
                        return;
                    }*/
                }
            }
        }
    }
}
