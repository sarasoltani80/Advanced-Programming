using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace finalproject
{
    class SaveLoadManagedatetimesdrhoseini_WriteReadAll: ISaveLoadManagedatetimesdrhoseini
    {
        public void SaveListToFile(string filePath, List<DateTime> appointmentList)
        {
            string content = "";
            foreach (var appointment in appointmentList)
            {
                content += appointment.ToString() + "\n";
            }
            File.WriteAllText(filePath, content);
        }
        public List<DateTime> ReadListFromFile(string filePath)
        {
            List<DateTime> appointmentList = new List<DateTime>();
            string[] appointmentsText = File.ReadAllLines(filePath);
            foreach (var line in appointmentsText)
            {
                appointmentList.Add(Convert.ToDateTime(line));
            }
            return appointmentList;
        }
    }
}
