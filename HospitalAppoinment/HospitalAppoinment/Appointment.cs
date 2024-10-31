using HospitalAppoinment;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace HospitalAppoinment;

public class Appointment
{
    private static int _no;
    public int No {  get; set; }
    public string Patient {  get; set; }
    public string Doctor { get; set; }
    public DateTime StartDate { get; set; }
    public DateTime EndDate { get; set; }
    public Appointment( string patient, string doctor, DateTime startDate, DateTime endDate)
    {
        No=++_no;
        Patient = patient;
        Doctor = doctor;
        StartDate = startDate;
        EndDate = endDate;
    }
}



//Appointment class
// -No
// - Patient
// - Doctor
// - StartDate
// - EndDate

