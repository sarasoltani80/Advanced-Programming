using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace finalproject
{
    class former_bimar:bimar
    {
        public int tedaddandan { set; get; }
        public static string bimarToString(former_bimar appointment)
        {
            return appointment.name + "," + appointment.familyname + "," + appointment.idnumber + "," + appointment.doctorname + "," + appointment.tedaddandan + "," + appointment.Time + "";
        }
        public static former_bimar StringTobimar(string appointmentText)
        {
            string[] propertiesText = appointmentText.Split(',');
            var bimar = new former_bimar
            {
                name = propertiesText[0],
                familyname = propertiesText[1],
                idnumber = propertiesText[2],
                doctorname = propertiesText[3],
                tedaddandan = Convert.ToInt32(propertiesText[4]),
                Time = Convert.ToDateTime(propertiesText[5])
            };
            return bimar;
        }
    }
}
