namespace MeetingProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //DateTime from = 2024 10 15;

            MeetingSchedule meet1 = new MeetingSchedule();
            meet1.SetMeeting("Ravan Bayramov", new DateTime(2027, 10, 15), new DateTime(2028, 04, 15));

            MeetingSchedule meet2 = new MeetingSchedule();
            meet2.SetMeeting("Farid Nadjafov", new DateTime(2024, 10, 15), new DateTime(2025, 04, 15));

            MeetingSchedule meet3 = new MeetingSchedule();
            meet3.SetMeeting("Ulvi Alizada", new DateTime(2024, 01, 15), new DateTime(2024, 04, 15));
            
        }
    }
}
