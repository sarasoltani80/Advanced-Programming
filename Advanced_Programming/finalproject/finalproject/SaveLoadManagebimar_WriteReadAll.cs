using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace finalproject
{
    class SaveLoadManagebimar_WriteReadAll : ISaveLoadManagebimar
    {
        public void SaveListToFile(string filePath, List<bimar> visitedbimarList)
        {
            string content = "";
            foreach (var appointment in visitedbimarList)
            {
                content += bimar.bimarToString(appointment) + "\n";
            }
            File.WriteAllText(filePath, content);
        }

        public List<bimar> ReadListFromFile(string filePath)
        {
            List<bimar> visitedbimarList = new List<bimar>();
            string[] appointmentsText = File.ReadAllLines(filePath);
            foreach (var line in appointmentsText)
            {
                visitedbimarList.Add(bimar.StringTobimar(line));
            }
            return visitedbimarList;
        }
    }
}
