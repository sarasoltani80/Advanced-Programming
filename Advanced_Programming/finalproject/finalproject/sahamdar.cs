using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace finalproject
{
    class sahamdar:doctor
    {
        public static string sahamdarToString(sahamdar person)
        {
            return person.idnumber + "," + person.darsadsahm + "," + person.salary;
        }
        public static sahamdar StringTosahamdar(string appointmentText)
        {
            string[] propertiesText = appointmentText.Split(',');
            var person = new sahamdar
            {
                idnumber = propertiesText[0],
                darsadsahm = Convert.ToInt32(propertiesText[1]),
                salary=Convert.ToDouble(propertiesText[2])
            };
            return person;
        }
    }
}
