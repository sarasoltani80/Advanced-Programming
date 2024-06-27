using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace finalproject
{
    interface ISaveLoadManageformerbimar
    {
        void SaveListToFile(string filePath, List<former_bimar> appointmentList);
        List<former_bimar> ReadListFromFile(string filePath);
    }
}
