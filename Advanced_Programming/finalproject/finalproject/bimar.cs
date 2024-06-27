using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace finalproject
{
    class bimar
    {
        public string name { get; set; }
        public string familyname { get; set; }
        public string idnumber { get; set; }
        public DateTime Time { set; get; }
        public string sabeqe { set; get; }
        public string doctorname { set; get; }
        public static string bimarToString(bimar appointment)
        {
            return appointment.name + "," + appointment.familyname + "," + appointment.idnumber + "," + appointment.doctorname + "," + appointment.sabeqe + "," + appointment.Time + "";
        }
        public static bimar StringTobimar(string appointmentText)
        {
            string[] propertiesText = appointmentText.Split(',');
            var bimar = new bimar
            {
                name = propertiesText[0],
                familyname = propertiesText[1],
                idnumber = propertiesText[2],
                doctorname=propertiesText[3],
                sabeqe = propertiesText[4],
                Time = Convert.ToDateTime(propertiesText[5])
            };
            return bimar;
        }
    }
}
