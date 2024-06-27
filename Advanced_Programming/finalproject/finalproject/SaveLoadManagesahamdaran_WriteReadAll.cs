using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace finalproject
{
    class SaveLoadManagesahamdaran_WriteReadAll : ISaveLoadManagesahamdaran
    {
        public void SaveListToFile(string filePath, List<sahamdar> sahamdarList)
        {
            string content = "";
            foreach (var appointment in sahamdarList)
            {
                content += sahamdar.sahamdarToString(appointment) + "\n";
            }
            File.WriteAllText(filePath, content);
        }

        public List<sahamdar> ReadListFromFile(string filePath)
        {
            List<sahamdar> sahamdarList = new List<sahamdar>();
            string[] appointmentsText = File.ReadAllLines(filePath);
            foreach (var line in appointmentsText)
            {
                sahamdarList.Add(sahamdar.StringTosahamdar(line));
            }
            return sahamdarList;
        }
    }
}
