using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace finalproject
{
    interface ISaveLoadManagedatetimesdrhoseini
    {
        void SaveListToFile(string filePath, List<DateTime> datetimeList);
        List<DateTime> ReadListFromFile(string filePath);
    }
}
