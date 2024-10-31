
namespace HospitalAppoinment;
internal class Program
{
    static void Main(string[] args)
    {
        //List<Appointment> app = [
        //    new Appointment(1,"Ravan Bayramov","Stomatolog",new DateTime(2024,10,30,10,00,00),new DateTime(2024,10,30,12,00,00)),
        //    new Appointment(2,"Farid Najafov","Narkolog",new DateTime(2024,10,21,09,00,00),new DateTime(2024,10,21,10,30,00)),
        //    new Appointment(3,"Talib Abilov","Psixiatr",new DateTime(2024,10,30,10,00,00),new DateTime(2024,10,30,10,45,00))

        //    ];
        //    



        Hospital diaqnoz = new Hospital();

        Console.WriteLine("Zehmet olmasa 1 ve 7 araliginda eded daxil edin: \n");
        Console.WriteLine("""
            1.Appointment yarat
            2. Appointment-i bitir
            3. Butun appointment-lere bax
            4. Bu hefteki appointment-lere bax
            5. Bugunki appointment-lere bax
            6. Bitmemis appointment-lere bax
            7. Menudan cix qısayoldur.

            """);
        bool isContinue = true;
        while (isContinue)
        {
            int count = int.Parse(Console.ReadLine());
            switch (count)
            {
                case 1:
                    Console.WriteLine("Pasiyentin melumatlarini daxil edin: \n");
                    Console.WriteLine("Ad(Soyad): ");
                    string name = Console.ReadLine();
                    Console.WriteLine("Hekim: ");
                    string doctor = Console.ReadLine();
                    Console.WriteLine("---------------------------------------------");
                    Console.WriteLine("Baslangic tarixi(il/ay/gun/saat/deqiqe/saniye): ");
                    int year = int.Parse(Console.ReadLine());
                    int month = int.Parse(Console.ReadLine());
                    int day = int.Parse(Console.ReadLine());
                    int hour = int.Parse(Console.ReadLine());   
                    int minute = int.Parse(Console.ReadLine()); 
                    int second = int.Parse(Console.ReadLine());
                    Console.WriteLine("-----------------------------------------");
                    Console.WriteLine("Bitis tarixi(il/ay/gun/saat/deqiqe/saniye): ");
                    int year2 = int.Parse(Console.ReadLine());
                    int month2 = int.Parse(Console.ReadLine());
                    int day2 = int.Parse(Console.ReadLine());
                    int hour2 = int.Parse(Console.ReadLine());
                    int minute2 = int.Parse(Console.ReadLine());
                    int second2 = int.Parse(Console.ReadLine());
                    Appointment app1 = new Appointment(name, doctor, new DateTime(year, month, day,hour,minute, second), new DateTime(year2, month2, day2, hour2, minute2, second2));
                    diaqnoz.AddAppoinment(app1);
                    Console.WriteLine("-----------------------------------------");
                    break;
                case 2:
                    int no = int.Parse(Console.ReadLine());
                    diaqnoz.EndAppoinment(no);
                    Console.WriteLine("-----------------------------------------");
                    break;
                case 3:
                    diaqnoz.GetAllAppointments();
                    Console.WriteLine("-----------------------------------------");
                    break;
                case 4:
                    diaqnoz.GetWeeklyAppointments();
                    Console.WriteLine("-----------------------------------------");
                    break;
                case 5:
                    diaqnoz.GetTodaysAppointments();
                    Console.WriteLine("-----------------------------------------");
                    break;
                case 6:
                    diaqnoz.GetAllContinuingAppointments();
                    Console.WriteLine("-----------------------------------------");
                    break;
                case 7:
                    isContinue = false;
                    Console.WriteLine("-----------------------------------------");
                    break;
                default:
                    Console.WriteLine("Zehmet olmasa 1 ve 7 araliginda eded daxil edin: \n");
                    Console.WriteLine("""
                    1.Appointment yarat
                    2. Appointment-i bitir
                    3. Bütün appointment-lərə bax
                    4. Bu həftəki appointment-lərə bax
                    5. Bugünki appointment-lərə bax
                    6. Bitməmiş appointmentlərə bax
                    7. Menudan çıx qısayoldur.

                    """);
                    break;
            }
        }
    }
}


//proqram run olunduqda console-da aşağıdakı menu göstərilir:
//1.Appointment yarat
//2. Appointment-i bitir
//3. Bütün appointment-lərə bax
//4. Bu həftəki appointment-lərə bax
//5. Bugünki appointment-lərə bax
//6. Bitməmiş appointmentlərə bax
//7. Menudan çıx