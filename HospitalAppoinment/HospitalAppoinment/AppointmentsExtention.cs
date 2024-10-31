using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalAppoinment
{
    public static class AppointmentsExtention
    {
        public static void PrintAppointments(this List<Appointment> list)
        {
            list.ForEach(item => Console.WriteLine($"{item.No} {item.Patient} {item.Doctor} {item.StartDate} {item.EndDate}"));
        }
    }
}
