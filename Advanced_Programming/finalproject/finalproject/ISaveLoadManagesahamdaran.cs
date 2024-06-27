using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace finalproject
{
    interface ISaveLoadManagesahamdaran
    {
        void SaveListToFile(string filePath, List<sahamdar> appointmentList);
        List<sahamdar> ReadListFromFile(string filePath);
    }
}
