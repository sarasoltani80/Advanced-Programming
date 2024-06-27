using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace finalproject
{
    class doctor:bimar
    {
        public double salary { set; get; }
        public int darsadsahm { set; get; }
        public static string doctorToString(doctor pezeshk)
        {
            return pezeshk.familyname + "," + pezeshk.idnumber + "," + pezeshk.salary + "," + pezeshk.darsadsahm;
        }
        public static doctor StringTodoctor(string appointmentText)
        {
            string[] propertiesText = appointmentText.Split(',');
            var pezeshk = new doctor
            {
                familyname = propertiesText[0],
                idnumber = propertiesText[1],
                salary = Convert.ToDouble(propertiesText[2]),
                darsadsahm = Convert.ToInt32(propertiesText[3])
            };
            return pezeshk;
        }
    }
}
