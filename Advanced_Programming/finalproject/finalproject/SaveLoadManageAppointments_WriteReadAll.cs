using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace finalproject
{
    class SaveLoadManageAppointments_WriteReadAll : ISaveLoadManageAppointments
    {
        public void SaveListToFile(string filePath, List<Appointment_drhoseini> appointmentList)
        {
            string content = "";
            foreach (var appointment in appointmentList)
            {
                content += Appointment_drhoseini.AppointmentToString(appointment) + "\n";
            }
            File.WriteAllText(filePath, content);
        }
        public List<Appointment_drhoseini> ReadListFromFile(string filePath)
        {
            List<Appointment_drhoseini> appointmentList = new List<Appointment_drhoseini>();
            string[] appointmentsText = File.ReadAllLines(filePath);
            foreach (var line in appointmentsText)
            {
                appointmentList.Add(Appointment_drhoseini.StringToAppointment(line));
            }
            return appointmentList;
        }
    }
}
