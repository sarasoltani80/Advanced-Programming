using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace finalproject
{
    class ManageAppointments
    {
        private readonly string _filePath;
        private readonly string filepath1;
        public DateTime finalappointment { set; get; }
        public DateTime finaldate { set; get; }
        public List<DateTime> Datelist { get; set; }
        public List<Appointment_drhoseini> AppointmentList { get; set; }
        private readonly ISaveLoadManageAppointments _saveLoader;
        private readonly ISaveLoadManagedatetimesdrhoseini _saveLoader1;
        public ManageAppointments(string filename, ISaveLoadManageAppointments saveLoader)
        {
            _saveLoader = saveLoader;
            _filePath = filename + "_" + _saveLoader.GetType().Name + ".txt";
            AppointmentList = new List<Appointment_drhoseini>();
            if (!File.Exists(_filePath))
                File.Create(_filePath).Close();
            else
                AppointmentList = _saveLoader.ReadListFromFile(_filePath);
        }
        public ManageAppointments(DateTime time, string filename, ISaveLoadManagedatetimesdrhoseini saveLoader)
        {
            _saveLoader1 = saveLoader;
            filepath1 = filename + "_" + _saveLoader1.GetType().Name + ".txt";
            Datelist = new List<DateTime>();
            if (!File.Exists(filepath1))
                File.Create(filepath1).Close();
            else
                Datelist = _saveLoader1.ReadListFromFile(filepath1);
        }
        public int adddate(DateTime time)
        {
            if (Datelist.Count == 0)
            {
                Datelist.Add(new DateTime(time.Year, time.Month, time.Day, 0, 0, 0));
                Datelist.Add(new DateTime(time.Year, time.Month, time.Day, 8, 0, 0));
                Datelist.Add(new DateTime(time.Year, time.Month, time.Day, 8, 30, 0));
                Datelist.Add(new DateTime(time.Year, time.Month, time.Day, 9, 0, 0));
                Datelist.Add(new DateTime(time.Year, time.Month, time.Day, 9, 30, 0));
                Datelist.Add(new DateTime(time.Year, time.Month, time.Day, 10, 0, 0));
                Datelist.Add(new DateTime(time.Year, time.Month, time.Day, 10, 30, 0));
                Datelist.Add(new DateTime(time.Year, time.Month, time.Day, 11, 0, 0));
                Datelist.Add(new DateTime(time.Year, time.Month, time.Day, 11, 30, 0));
                Datelist.Add(new DateTime(time.Year, time.Month, time.Day, 12, 0, 0));
                Datelist.Add(new DateTime(time.Year, time.Month, time.Day, 12, 30, 0));
                Datelist.Add(new DateTime(time.Year, time.Month, time.Day, 13, 0, 0));
                Datelist.Add(new DateTime(time.Year, time.Month, time.Day, 13, 30, 0));
                Datelist.Add(new DateTime(time.Year, time.Month, time.Day, 14, 0, 0));
                Datelist.Add(new DateTime(time.Year, time.Month, time.Day, 14, 30, 0));
                Datelist.Add(new DateTime(time.Year, time.Month, time.Day, 15, 0, 0));
                Datelist.Add(new DateTime(time.Year, time.Month, time.Day, 15, 30, 0));
                Datelist.Add(new DateTime(time.Year, time.Month, time.Day, 16, 0, 0));
                _saveLoader1.SaveListToFile(filepath1, Datelist);
                return 1;
            }
            else
            {
                int flag = 0;
                foreach(var item in Datelist)
                {
                    if(item.Year==time.Year&&item.Month==time.Month&&item.Day==time.Day)
                    {
                        flag = 1;
                    }
                }
                if(flag==0)
                {
                    Datelist.Add(new DateTime(time.Year, time.Month, time.Day, 0, 0, 0));
                    Datelist.Add(new DateTime(time.Year, time.Month, time.Day, 8, 0, 0));
                    Datelist.Add(new DateTime(time.Year, time.Month, time.Day, 8, 30, 0));
                    Datelist.Add(new DateTime(time.Year, time.Month, time.Day, 9, 0, 0));
                    Datelist.Add(new DateTime(time.Year, time.Month, time.Day, 9, 30, 0));
                    Datelist.Add(new DateTime(time.Year, time.Month, time.Day, 10, 0, 0));
                    Datelist.Add(new DateTime(time.Year, time.Month, time.Day, 10, 30, 0));
                    Datelist.Add(new DateTime(time.Year, time.Month, time.Day, 11, 0, 0));
                    Datelist.Add(new DateTime(time.Year, time.Month, time.Day, 11, 30, 0));
                    Datelist.Add(new DateTime(time.Year, time.Month, time.Day, 12, 0, 0));
                    Datelist.Add(new DateTime(time.Year, time.Month, time.Day, 12, 30, 0));
                    Datelist.Add(new DateTime(time.Year, time.Month, time.Day, 13, 0, 0));
                    Datelist.Add(new DateTime(time.Year, time.Month, time.Day, 13, 30, 0));
                    Datelist.Add(new DateTime(time.Year, time.Month, time.Day, 14, 0, 0));
                    Datelist.Add(new DateTime(time.Year, time.Month, time.Day, 14, 30, 0));
                    Datelist.Add(new DateTime(time.Year, time.Month, time.Day, 15, 0, 0));
                    Datelist.Add(new DateTime(time.Year, time.Month, time.Day, 15, 30, 0));
                    Datelist.Add(new DateTime(time.Year, time.Month, time.Day, 16, 0, 0));
                    _saveLoader1.SaveListToFile(filepath1, Datelist);
                    return 1;
                }
                else
                {
                    int number = 0;
                    foreach(var item1 in Datelist)
                    {
                        if(item1.Year==time.Year&&item1.Month==time.Month&&item1.Day==time.Day)
                        {
                            number++;
                        }
                    }
                    if(number==1)
                    {
                        return 0;
                    }
                    if(number==2)
                    {
                        int flag2 = 0;
                        foreach (var item2 in Datelist)
                        {
                            if (item2.Year == time.Year && item2.Month == time.Month && item2.Day == time.Day)
                            {
                                if(item2.Hour==0||item2.Hour==16)
                                {
                                    
                                }
                                else
                                {
                                    flag2 = 1;
                                }
                            }
                        }
                        if(flag2==0)
                        {
                            return 0;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }
        public void sorting(ManageAppointments manage)
        {
            Appointment_drhoseini temp = new Appointment_drhoseini();
            for (int i = 1; i < manage.AppointmentList.Count; i++)
            {
                for (int j = 0; j < manage.AppointmentList.Count - i; j++)
                {
                    if(manage.AppointmentList[j].Time.Month== manage.AppointmentList[j+1].Time.Month)
                    {
                        if(manage.AppointmentList[j].Time.Day == manage.AppointmentList[j + 1].Time.Day)
                        {
                            if(manage.AppointmentList[j].Time.Hour == manage.AppointmentList[j + 1].Time.Hour)
                            {
                                if(manage.AppointmentList[j].Time.Minute > manage.AppointmentList[j + 1].Time.Minute)
                                {
                                    temp.Time = manage.AppointmentList[j].Time;
                                    manage.AppointmentList[j].Time = manage.AppointmentList[j + 1].Time;
                                    manage.AppointmentList[j + 1].Time = temp.Time;
                                }
                            }
                            if(manage.AppointmentList[j].Time.Hour > manage.AppointmentList[j + 1].Time.Hour)
                            {
                                temp.Time = manage.AppointmentList[j].Time;
                                manage.AppointmentList[j].Time = manage.AppointmentList[j + 1].Time;
                                manage.AppointmentList[j + 1].Time = temp.Time;
                            }
                        }
                        if(manage.AppointmentList[j].Time.Day > manage.AppointmentList[j + 1].Time.Day)
                        {
                            temp.Time = manage.AppointmentList[j].Time;
                            manage.AppointmentList[j].Time = manage.AppointmentList[j + 1].Time;
                            manage.AppointmentList[j + 1].Time = temp.Time;
                        }
                    }
                    if(manage.AppointmentList[j].Time.Month > manage.AppointmentList[j + 1].Time.Month)
                    {
                        temp.Time = manage.AppointmentList[j].Time;
                        manage.AppointmentList[j].Time = manage.AppointmentList[j + 1].Time;
                        manage.AppointmentList[j + 1].Time = temp.Time;
                    }
                }
            }
            _saveLoader.SaveListToFile(_filePath, manage.AppointmentList);
            return;
        }
        public void sorting_Datelist(List<DateTime> listofdates)
        {
            DateTime temp = new DateTime();
            for (int i = 1; i < listofdates.Count; i++)
            {
                for (int j = 0; j < listofdates.Count - i; j++)
                {
                    if (listofdates[j].Hour > listofdates[j + 1].Hour)
                    {
                        temp = listofdates[j];
                        listofdates[j] = listofdates[j + 1];
                        listofdates[j + 1] = temp;
                    }
                    if (listofdates[j].Hour == listofdates[j + 1].Hour)
                    {
                        if (listofdates[j].Minute > listofdates[j + 1].Minute)
                        {
                            temp = listofdates[j];
                            listofdates[j] = listofdates[j + 1];
                            listofdates[j + 1] = temp;
                        }
                    }
                }
            }
        }
        public void check(Appointment_drhoseini appointment, string Mahdood, int tedad, DateTime time)
        {
            if (tedad == 1 && Mahdood == "0")
            {
                List<DateTime> secondlist = new List<DateTime>();
                foreach (var item in Datelist)
                {
                    if (time.Year == item.Year && time.Month == item.Month && time.Day == item.Day)
                    {
                        if (item.Hour != 0)
                        {
                            secondlist.Add(item);
                        }
                    }
                }
                appointment.Time = secondlist[0];
                if (secondlist[0].Hour == 16)
                {
                    DateTime dt = new DateTime(time.Year, time.Month, time.Day, 16, 30, 0);
                    appointment.Time = dt;
                }
                foreach (var item1 in Datelist)
                {
                    if (item1 == secondlist[0])
                    {
                        Datelist.Remove(item1);
                        _saveLoader1.SaveListToFile(filepath1, Datelist);
                        return;
                    }
                }
            }
            if (tedad == 1 && Mahdood == "1")
            {
                int flag = 0;
                foreach (var item in Datelist)
                {
                    if (item.Hour == 8 || item.Hour == 9 || item.Hour == 10 || item.Hour == 11 || item.Hour == 12 && item.Minute == 0 || item.Hour == 0 || item.Hour == 16)
                    {

                    }
                    else
                    {
                        flag = 1;
                    }
                    if (flag == 1)
                    {
                        appointment.Time = item;
                        Datelist.Remove(item);
                        _saveLoader1.SaveListToFile(filepath1, Datelist);
                        return;
                    }
                }
                if (flag == 0)
                {
                    appointment.Time.AddHours(16);
                    appointment.Time.AddMinutes(30);
                }
            }
            if (tedad == 1 && Mahdood == "2")
            {
                int flag = 0;
                foreach (var item in Datelist)
                {
                    if (item.Hour == 13 || item.Hour == 14 || item.Hour == 15 || item.Hour == 12 && item.Minute == 30 || item.Hour == 0 || item.Hour == 16)
                    {

                    }
                    else
                    {
                        flag = 1;
                    }
                    if (flag == 1)
                    {
                        appointment.Time = item;
                        Datelist.Remove(item);
                        _saveLoader1.SaveListToFile(filepath1, Datelist);
                        return;
                    }
                }
                if (flag == 0)
                {
                    appointment.Time.AddHours(16);
                    appointment.Time.AddMinutes(30);
                }
            }
            if (tedad != 1)
            {
                if (Mahdood == "0")
                {
                    List<DateTime> secondlist = new List<DateTime>();
                    foreach (var item in Datelist)
                    {
                        if (time.Year == item.Year && time.Month == item.Month && time.Day == item.Day && item.Hour != 0)
                        {
                            secondlist.Add(item);
                        }
                    }
                    if (secondlist.Count < tedad)
                    {
                        DateTime dt = new DateTime(time.Year, time.Month, time.Day, 16, 30, 0);
                        appointment.Time = dt;
                    }
                    else
                    {
                        DateTime item1 = new DateTime();
                        int j = 0;
                        int flag1 = 0;
                        while (j < secondlist.Count)
                        {
                            item1 = secondlist[j];
                            int i = 1;
                            int flag = 0;
                            while (i < tedad)
                            {
                                item1 = item1.AddMinutes(30);
                                if (Datelist.Contains(item1))
                                {
                                    i++;
                                }
                                else
                                {
                                    flag = 1;
                                    break;
                                }
                            }
                            if (flag == 1)
                            {
                                j++;
                            }
                            else
                            {
                                flag1 = 1;
                                break;
                            }
                        }
                        if (flag1 == 1)
                        {
                            for (int k = 0; k < tedad; k++)
                            {
                                foreach (var item2 in Datelist)
                                {
                                    if (item2 == secondlist[j])
                                    {
                                        Datelist.Remove(item2);
                                        break;
                                    }
                                }
                                j++;
                            }
                            _saveLoader1.SaveListToFile(filepath1, Datelist);
                            appointment.Time = secondlist[j - tedad];
                            if (appointment.Time.Hour == 16)
                            {
                                DateTime dt = new DateTime(time.Year, time.Month, time.Day, 16, 30, 0);
                                appointment.Time = dt;
                            }
                        }
                        else
                        {
                            DateTime dt = new DateTime(time.Year, time.Month, time.Day, 16, 30, 0);
                            appointment.Time = dt;
                        }
                    }
                }
                if (Mahdood == "1")
                {
                    List<DateTime> secondlist = new List<DateTime>();
                    foreach (var item in Datelist)
                    {
                        if (time.Year == item.Year && time.Month == item.Month && time.Day == item.Day)
                        {
                            if (item.Hour >= 8 && item.Hour < 12 || item.Hour == 12 && item.Minute == 0 || item.Hour == 0)
                            {

                            }
                            else
                            {
                                secondlist.Add(item);
                            }
                        }
                    }
                    if (secondlist.Count < tedad)
                    {
                        DateTime dt = new DateTime(time.Year, time.Month, time.Day, 16, 30, 0);
                        appointment.Time = dt;
                    }
                    else
                    {
                        DateTime item1 = new DateTime();
                        int j = 0;
                        int flag1 = 0;
                        while (j < secondlist.Count)
                        {
                            item1 = secondlist[j];
                            int i = 1;
                            int flag = 0;
                            while (i < tedad)
                            {
                                item1 = item1.AddMinutes(30);
                                if (Datelist.Contains(item1))
                                {
                                    i++;
                                }
                                else
                                {
                                    flag = 1;
                                    break;
                                }
                            }
                            if (flag == 1)
                            {
                                j++;
                            }
                            else
                            {
                                flag1 = 1;
                                break;
                            }
                        }
                        if (flag1 == 1)
                        {
                            for (int k = 0; k < tedad; k++)
                            {
                                foreach (var item2 in Datelist)
                                {
                                    if (item2 == secondlist[j])
                                    {
                                        Datelist.Remove(item2);
                                        break;
                                    }
                                }
                                j++;
                            }
                            appointment.Time = secondlist[j - tedad];
                            _saveLoader1.SaveListToFile(filepath1, Datelist);
                            if (appointment.Time.Hour == 16)
                            {
                                DateTime dt = new DateTime(time.Year, time.Month, time.Day, 16, 30, 0);
                                appointment.Time = dt;
                            }
                        }
                        else
                        {
                            DateTime dt = new DateTime(time.Year, time.Month, time.Day, 16, 30, 0);
                            appointment.Time = dt;
                        }
                    }
                }
                if (Mahdood == "2")
                {
                    List<DateTime> secondlist = new List<DateTime>();
                    foreach (var item in Datelist)
                    {
                        if (time.Year == item.Year && time.Month == item.Month && time.Day == item.Day)
                        {
                            if (item.Hour > 12 && item.Hour <= 16 || item.Hour == 12 && item.Minute == 30 || item.Hour == 0)
                            {

                            }
                            else
                            {
                                secondlist.Add(item);
                            }
                        }
                    }
                    if (secondlist.Count < tedad)
                    {
                        DateTime dt = new DateTime(time.Year, time.Month, time.Day, 16, 30, 0);
                        appointment.Time = dt;
                    }
                    else
                    {
                        DateTime item1 = new DateTime();
                        int j = 0;
                        int flag1 = 0;
                        while (j < secondlist.Count)
                        {
                            item1 = secondlist[j];
                            int i = 1;
                            int flag = 0;
                            while (i < tedad)
                            {
                                item1 = item1.AddMinutes(30);
                                if (Datelist.Contains(item1))
                                {
                                    i++;
                                }
                                else
                                {
                                    flag = 1;
                                    break;
                                }
                            }
                            if (flag == 1)
                            {
                                j++;
                            }
                            else
                            {
                                flag1 = 1;
                                break;
                            }
                        }
                        if (flag1 == 1)
                        {
                            for (int k = 0; k < tedad; k++)
                            {
                                foreach (var item2 in Datelist)
                                {
                                    if (item2 == secondlist[j])
                                    {
                                        Datelist.Remove(item2);
                                        break;
                                    }
                                }
                                j++;
                            }
                            appointment.Time = secondlist[j - tedad];
                            _saveLoader1.SaveListToFile(filepath1, Datelist);
                            if (appointment.Time.Hour == 16)
                            {
                                DateTime dt = new DateTime(time.Year, time.Month, time.Day, 16, 30, 0);
                                appointment.Time = dt;
                            }
                        }
                        else
                        {
                            DateTime dt = new DateTime(time.Year, time.Month, time.Day, 16, 30, 0);
                            appointment.Time = dt;
                        }
                    }
                }
            }
        }
        public int AddAppointment(Appointment_drhoseini appointment)
        {
            if ((appointment.Time.Hour == 16 && appointment.Time.Minute == 30) || appointment.Time.Hour > 16)
            {
                return 0;
            }
            else
            {
                AppointmentList.Add(appointment);
                _saveLoader.SaveListToFile(_filePath, AppointmentList);
                return 1;
            }
        }
        public void findthebesttime_drhoseini(Appointment_drhoseini molaghat, ManageAppointments manageAppointments, ManageAppointments manage, string ismahdood, string dayofweek, int numberofteeth)
        {
            molaghat.Time = molaghat.Time.AddDays(1);
            if (molaghat.Time.DayOfWeek == DayOfWeek.Thursday)
            {
                molaghat.Time = molaghat.Time.AddDays(2);
            }
            if (molaghat.Time.DayOfWeek == DayOfWeek.Friday)
            {
                molaghat.Time = molaghat.Time.AddDays(1);
            }
            if (dayofweek == "zoj" && (molaghat.Time.DayOfWeek == DayOfWeek.Sunday || molaghat.Time.DayOfWeek == DayOfWeek.Tuesday))
            {
                molaghat.Time = molaghat.Time.AddDays(1);
            }
            if (dayofweek == "fard" && (molaghat.Time.DayOfWeek == DayOfWeek.Saturday || molaghat.Time.DayOfWeek == DayOfWeek.Monday))
            {
                molaghat.Time = molaghat.Time.AddDays(1);
            }
            if (dayofweek == "fard" && molaghat.Time.DayOfWeek == DayOfWeek.Wednesday)
            {
                molaghat.Time = molaghat.Time.AddDays(4);
            }
            DateTime newdate = new DateTime(molaghat.Time.Year, molaghat.Time.Month, molaghat.Time.Day, 10, 10, 10);
            var appointment3 = new Appointment_drhoseini { Time = newdate };
            int y = manage.adddate(appointment3.Time);
            if (y == 1)
            {
                manage.check(appointment3, ismahdood, numberofteeth, appointment3.Time);
                int x = manageAppointments.AddAppointment(appointment3);
                if (x == 1)
                {
                    finalappointment = appointment3.Time;
                    return;
                }
                else
                {
                    findthebesttime_drhoseini(molaghat, manageAppointments, manage, ismahdood, dayofweek, numberofteeth);
                }
            }
            else
            {
                findthebesttime_drhoseini(molaghat, manageAppointments, manage, ismahdood, dayofweek, numberofteeth);
            }
        }
        public DateTime finaltime(ManageAppointments manageAppointments,ManageAppointments manage,Appointment_drhoseini appointment2,string IsMahdood,string dayofweek,int numberofteeth)
        {
            int y = manage.adddate(appointment2.Time);
            if (y == 1)
            {
                manage.check(appointment2, IsMahdood, numberofteeth, appointment2.Time);
                int x = manageAppointments.AddAppointment(appointment2);
                if (x == 1)
                {
                    finaldate = appointment2.Time;
                    return finaldate;
                }
                else
                {
                    manageAppointments.findthebesttime_drhoseini(appointment2, manageAppointments, manage, IsMahdood, dayofweek, numberofteeth);
                    finaldate = manageAppointments.finalappointment;
                    return finaldate;
                }
            }
            else
            {
                manageAppointments.findthebesttime_drhoseini(appointment2, manageAppointments, manage, IsMahdood, dayofweek, numberofteeth);
                finaldate = manageAppointments.finalappointment;
                return finaldate;
            }
        }
        public void cancel_fromAppointmentsList(DateTime canceled_time,int tedaddandan)
        {
            foreach(var item in AppointmentList)
            {
                if(item.Time==canceled_time)
                {
                    AppointmentList.Remove(item);
                    _saveLoader.SaveListToFile(_filePath, AppointmentList);
                    break;
                }
            }
        }
        public void Add_to_DateList(DateTime canceled_time, int tedaddandan)
        {
            Datelist.Add(canceled_time);
            for (int i = 0; i < tedaddandan - 1; i++)
            {
                canceled_time = canceled_time.AddMinutes(30);
                Datelist.Add(canceled_time);
            }
            sorting_Datelist(Datelist);
            _saveLoader1.SaveListToFile(filepath1, Datelist);
        }
    }
}
