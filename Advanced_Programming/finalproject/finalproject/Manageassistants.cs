using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace finalproject
{
    class Manageassistants
    {
        private readonly string _filePath;
        public List<assistants> assistantlist { get; set; }
        private readonly ISaveLoadManageAppointments_assistants _saveLoader;
        public Manageassistants(string filename, ISaveLoadManageAppointments_assistants saveLoader)
        {
            _saveLoader = saveLoader;
            _filePath = filename + "_" + _saveLoader.GetType().Name + ".txt";
            assistantlist = new List<assistants>();

            if (!File.Exists(_filePath))
                File.Create(_filePath).Close();
            else
                assistantlist = _saveLoader.ReadListFromFile(_filePath);
        }
        public void Addassistants(assistants appointment)
        {
            int flag = 0;
            foreach(var item in assistantlist)
            {
                if(item.idnumber==appointment.idnumber)
                {
                    flag = 1;
                }
            }
            if (flag == 0)
            {
                assistantlist.Add(appointment);
                _saveLoader.SaveListToFile(_filePath, assistantlist);
            }
        }
        public int checkassistants(assistants monshi,string nameofdoctor)
        {
            int flag = 0;
            foreach(var item in assistantlist)
            {
                if(item.name==monshi.name&&item.familyname==monshi.familyname&&item.idnumber==monshi.idnumber&&item.doctorname==monshi.doctorname&&monshi.doctorname==nameofdoctor)
                {
                    flag = 1;
                }
            }
            if(flag==1)
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }
        public int check_Isassistant(string _name,string _familyname,string _idnumber,string _doctorname)
        {
            int flag = 0;
            foreach (var item in assistantlist)
            {
                if (item.name == _name && item.familyname == _familyname && item.idnumber == _idnumber && item.doctorname == _doctorname)
                {
                    flag = 1;
                }
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
        public double Addsalary()
        {
            double x = 0;
            foreach(var item in assistantlist)
            {
                item.salary += item.pishfarzsalary;
                _saveLoader.SaveListToFile(_filePath, assistantlist);
                x += item.pishfarzsalary;
            }
            return x;
        }
        public void changesalary(List<string> mylist,int newsalary)
        {
            foreach(var item in assistantlist)
            {
                foreach(var item1 in mylist)
                {
                    if(item.doctorname==item1)
                    {
                        item.pishfarzsalary = newsalary;
                        _saveLoader.SaveListToFile(_filePath, assistantlist);
                    }
                }
            }
        }
        public void change_idnumber(string doctorname,string new_id)
        {
            foreach(var item in assistantlist)
            {
                if(item.doctorname==doctorname)
                {
                    item.idnumber = new_id;
                    _saveLoader.SaveListToFile(_filePath, assistantlist);
                    return;
                }
            }
        }

    }
}
