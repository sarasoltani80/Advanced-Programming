using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace finalproject
{
    class SaveLoadManagedoctors_WriteReadAll : ISaveLoadManagedoctors
    {
        public void SaveListToFile(string filePath, List<doctor> doctorlist)
        {
            string content = "";
            foreach (var pezeshk in doctorlist)
            {
                content += doctor.doctorToString(pezeshk) + "\n";
            }
            File.WriteAllText(filePath, content);
        }
        public List<doctor> ReadListFromFile(string filePath)
        {
            List<doctor> doctorlist = new List<doctor>();
            string[] appointmentsText = File.ReadAllLines(filePath);
            foreach (var line in appointmentsText)
            {
                doctorlist.Add(doctor.StringTodoctor(line));
            }
            return doctorlist;
        }
    }
}
