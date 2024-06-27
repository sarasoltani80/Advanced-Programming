using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace finalproject
{
    class SaveLoadManageAppointments_WriteReadAll_assistants : ISaveLoadManageAppointments_assistants
    {
        public void SaveListToFile(string filePath, List<assistants> assistantlist)
        {
            string content = "";
            foreach (var appointment in assistantlist)
            {
                content += assistants.assistantToString(appointment) + "\n";
            }
            File.WriteAllText(filePath, content);
        }

        public List<assistants> ReadListFromFile(string filePath)
        {
            List<assistants> assistantlist = new List<assistants>();
            string[] appointmentsText = File.ReadAllLines(filePath);
            foreach (var line in appointmentsText)
            {
                assistantlist.Add(assistants.StringToassistant(line));
            }
            return assistantlist;
        }
    }
}
