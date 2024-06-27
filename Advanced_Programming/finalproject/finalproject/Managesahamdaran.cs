using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace finalproject
{
    class Managesahamdaran
    {
        private readonly string _filePath;
        public List<sahamdar> sahamdarList { get; set; }
        private readonly ISaveLoadManagesahamdaran _saveLoader;
        public Managesahamdaran(string filename, ISaveLoadManagesahamdaran saveLoader)
        {
            _saveLoader = saveLoader;
            _filePath = filename + "_" + _saveLoader.GetType().Name + ".txt";
            sahamdarList = new List<sahamdar>();

            if (!File.Exists(_filePath))
                File.Create(_filePath).Close();
            else
                sahamdarList = _saveLoader.ReadListFromFile(_filePath);
        }
        public int Addsahamdar(sahamdar person)
        {
            int flag = 0;
            int sum_of_darsadha = 0;
            foreach (var item in sahamdarList)
            {
                if (item.idnumber == person.idnumber)
                {
                    flag = 1;
                }
                sum_of_darsadha += item.darsadsahm;
            }
            if (flag == 0)
            {
                if (sum_of_darsadha + person.darsadsahm > 100)
                {
                    return 0;
                }
                else
                {
                    sahamdarList.Add(person);
                    _saveLoader.SaveListToFile(_filePath, sahamdarList);
                    return 1;
                }
            }
            else
            {
                return 0;
            }
        }
        public double Addsalary(double money)
        {
            double baghimande=0;
            foreach(var item in sahamdarList)
            {
                item.salary += ((item.darsadsahm * money)/100);
                baghimande += ((item.darsadsahm * money)/100);
            }
            _saveLoader.SaveListToFile(_filePath, sahamdarList);
            return baghimande;
        }
        public void changedarsadsahm(string id,int newdarsad)
        {
            foreach(var item in sahamdarList)
            {
                if(item.idnumber==id)
                {
                    item.darsadsahm = newdarsad;
                    _saveLoader.SaveListToFile(_filePath, sahamdarList);
                    return;
                }
            }
        }
    }
}
