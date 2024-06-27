using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace finalproject
{
    class Managedoctors
    {
        private readonly string _filePath;
        public List<doctor> doctorlist { get; set; }
        private readonly ISaveLoadManagedoctors _saveLoader;
        public Managedoctors(string filename, ISaveLoadManagedoctors saveLoader)
        {
            _saveLoader = saveLoader;
            _filePath = filename + "_" + _saveLoader.GetType().Name + ".txt";
            doctorlist = new List<doctor>();

            if (!File.Exists(_filePath))
                File.Create(_filePath).Close();
            else
                doctorlist = _saveLoader.ReadListFromFile(_filePath);
        }
        public void Adddoctors(doctor pezeshk)
        {
            int flag = 0;
            foreach (var item in doctorlist)
            {
                if (item.idnumber == pezeshk.idnumber)
                {
                    flag = 1;
                }
            }
            if (flag == 0)
            {
                doctorlist.Add(pezeshk);
                _saveLoader.SaveListToFile(_filePath, doctorlist);
            }
        }
        public int checkdoctors(doctor pezeshk,string doctorname)
        {
            int flag = 0;
            foreach (var item in doctorlist)
            {
                if (item.familyname == pezeshk.familyname && item.idnumber == pezeshk.idnumber&&item.familyname==doctorname) 
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
        public int checked_Isdoctor(string doctorname,string idnumber)
        {
            int flag = 0;
            foreach(var item in doctorlist)
            {
                if(item.familyname==doctorname&&item.idnumber==idnumber)
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
        public void Addsalary(string doctorname,double salary1)
        {
            foreach(var item in doctorlist)
            {
                if(item.familyname==doctorname)
                {
                    item.salary += salary1;
                    _saveLoader.SaveListToFile(_filePath, doctorlist);
                }
            }
        }
        public void change_idnumber(string doctorname,string new_idnumber)
        {
            foreach(var item in doctorlist)
            {
                if(item.familyname==doctorname)
                {
                    item.idnumber = new_idnumber;
                    _saveLoader.SaveListToFile(_filePath, doctorlist);
                    return;
                }
            }
        }
    }
}
