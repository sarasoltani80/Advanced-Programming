using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace finalproject
{
    class Managebimar
    {
        private readonly string _filePath;
        public List<bimar> searachedlist { set; get; }
        public List<bimar> visitedbimarList { get; set; }
        private readonly ISaveLoadManagebimar _saveLoader;
        public Managebimar(string filename, ISaveLoadManagebimar saveLoader)
        {
            _saveLoader = saveLoader;
            _filePath = filename + "_" + _saveLoader.GetType().Name + ".txt";
            visitedbimarList = new List<bimar>();

            if (!File.Exists(_filePath))
                File.Create(_filePath).Close();
            else
                visitedbimarList = _saveLoader.ReadListFromFile(_filePath);
        }
        public void Addbimar(bimar appointment)
        {
            visitedbimarList.Add(appointment);
            _saveLoader.SaveListToFile(_filePath, visitedbimarList);
        }
        public List<bimar> searchbimar(string _doctorname)
        {
            List<bimar> searchedbimarList = new List<bimar>();
            foreach (var item in visitedbimarList)
            {
                if (item.doctorname == _doctorname)
                {
                    searchedbimarList.Add(item);
                }
            }
            return searchedbimarList;
        }
        public int Is_bimar(string idnumber,string doctorname)
        {
            searachedlist = new List<bimar>();
            int flag = 0;
            foreach (var item in visitedbimarList)
            {
                if (item.idnumber == idnumber && item.doctorname == doctorname)
                {
                    flag = 1;
                    searachedlist.Add(item);
                }
            }
            if (flag == 1)
                return 1;
            else
                return 0;
        }
        public string Is_takmili_by_doctor(string _name,string _familyname,string _id)
        {
            int flag = 0;
            int number = 0;
            foreach (var item in visitedbimarList)
            {
                if (item.name == _name && item.familyname == _familyname && item.idnumber == _id&&(item.doctorname=="dr.karimi"||item.doctorname=="dr.mortazavi"))
                {
                    flag = 1;
                    break;
                }
                number++;
            }
            if (flag == 1)
            {
                if (visitedbimarList[number].sabeqe.Contains("(") == true)
                {
                    char[] spearator = { '(', ')' };
                    string[] strlist = visitedbimarList[number].sabeqe.Split(spearator, StringSplitOptions.RemoveEmptyEntries);
                    if (strlist[1] == " darmane rishe dosathi "||strlist[1]== " darmane rishe sesathi ")
                    {
                        return visitedbimarList[number].doctorname;
                    }
                    else
                    {
                        return "0";
                    }
                }
                else
                {
                    return "0";
                }
            }
            else
            {
                return "0";
            }
        }
    }
}
