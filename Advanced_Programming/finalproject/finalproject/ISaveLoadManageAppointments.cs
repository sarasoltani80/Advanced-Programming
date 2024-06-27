using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace finalproject
{
    interface ISaveLoadManageAppointments
    {
        void SaveListToFile(string filePath, List<Appointment_drhoseini> appointmentList);
        List<Appointment_drhoseini> ReadListFromFile(string filePath);
    }
}
