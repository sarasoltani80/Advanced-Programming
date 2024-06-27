using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace finalproject
{
    interface ISaveLoadManageAppointments_assistants
    {
        void SaveListToFile(string filePath, List<assistants> assistantlist);
        List<assistants> ReadListFromFile(string filePath);
    }
}
