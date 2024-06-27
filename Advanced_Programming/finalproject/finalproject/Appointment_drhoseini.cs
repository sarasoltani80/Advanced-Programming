using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml.Serialization;

namespace finalproject
{
    [Serializable]
    class Appointment_drhoseini
    {
        public DateTime Time { get; set; }
        public static string AppointmentToString(Appointment_drhoseini appointment)
        {
            return appointment.Time + "";
        }
        public static Appointment_drhoseini StringToAppointment(string appointmentText)
        {
            var appointment = new Appointment_drhoseini
            {
                Time = Convert.ToDateTime(appointmentText)
            };
            return appointment;
        }
    }
}
