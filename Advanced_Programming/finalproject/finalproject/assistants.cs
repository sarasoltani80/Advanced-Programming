using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace finalproject
{
    class assistants:bimar
    {
        private double Pishfarzsalary;
        public double salary { get; set; }
        public double pishfarzsalary
        {
            set
            {
                if(value>0)
                this.Pishfarzsalary = value;
            }
            get
            {
                return Pishfarzsalary;
            }
        }
        public static string assistantToString(assistants monshi)
        {
            return monshi.name + "," + monshi.familyname + "," + monshi.idnumber + "," + monshi.doctorname + "," + monshi.salary+","+monshi.pishfarzsalary;
        }
        public static assistants StringToassistant(string appointmentText)
        {
            string[] propertiesText = appointmentText.Split(',');
            var monshi = new assistants
            {
                name = propertiesText[0],
                familyname = propertiesText[1],
                idnumber = propertiesText[2],
                doctorname = propertiesText[3],
                salary = Convert.ToDouble(propertiesText[4]),
                pishfarzsalary=Convert.ToInt32(propertiesText[5])
            };
            return monshi;
        }
    }
}
