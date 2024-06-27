using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace finalproject
{
    class SaveLoadManageformerbimar_WriteReadAll: ISaveLoadManageformerbimar
    {
        public void SaveListToFile(string filePath, List<former_bimar> notyetvisitedbimarList)
        {
            string content = "";
            foreach (var appointment in notyetvisitedbimarList)
            {
                content += former_bimar.bimarToString(appointment) + "\n";
            }
            File.WriteAllText(filePath, content);
        }

        public List<former_bimar> ReadListFromFile(string filePath)
        {
            List<former_bimar> notyetvisitedbimarList = new List<former_bimar>();
            string[] appointmentsText = File.ReadAllLines(filePath);
            foreach (var line in appointmentsText)
            {
                notyetvisitedbimarList.Add(former_bimar.StringTobimar(line));
            }
            return notyetvisitedbimarList;
        }
    }
}
