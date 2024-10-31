using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using static System.Reflection.Metadata.BlobBuilder;

namespace HospitalAppoinment;

public class Hospital
{
    List<Appointment> Appointments = [];
    public void AddAppoinment(Appointment appointments)
    {
        Appointments.Add(appointments);
    }
    public void EndAppoinment(int no)
    {
        Appointment appointment = Appointments.Find(x=> x.No==no);
        appointment.EndDate = DateTime.Now;
    }
    public Appointment GetAppointment(int no)
    {
        Appointment appointment = Appointments.Find(x => x.No == no);
        return appointment;
    }
    public void GetAllAppointments()
    {
        //Appointments.ForEach(item => Console.WriteLine($"{item.No} {item.Patient} {item.Doctor} {item.StartDate} {item.EndDate}"));   
        Appointments.PrintAppointments();
    }
    public void GetWeeklyAppointments()
    {
        Appointments.FindAll(x=> DateTime.Now.AddDays(-7)<x.StartDate).PrintAppointments();
    }
    public void GetTodaysAppointments()
    {
        Appointments.FindAll(x => DateTime.Today < x.StartDate).PrintAppointments();
    }
    public void GetAllContinuingAppointments()
    {
        Appointments.FindAll(x => DateTime.Now > x.StartDate && DateTime.Now <x.EndDate).PrintAppointments();
    }
    //public Hospital( int no, string patient, string doctor, DateTime startDate, DateTime endDate) : base(no, patient, doctor, startDate, endDate)
    //{
       
    //}
}

//Book? book = Books.Find(b => b.Id == id);
//Hospital class
// -Appointments
// - AddAppointment()
// - EndAppointment() - no deyeri gelir ve hemin appointmentin
//                      enddate-ini qeyd edir
// - GetAppointment() - no deyeri qebul ve hemin appointmenti
//                      return edir
// - GetAllAppointments()
// - GetWeeklyAppointments()
// - GetTodaysAppointments()
// - GetAllContinuingAppointments()