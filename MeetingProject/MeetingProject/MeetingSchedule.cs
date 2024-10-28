namespace MeetingProject
{
    public class MeetingSchedule
    {
        public static Meeting[] Meetings = new Meeting[0];

        public void SetMeeting(string fullName, DateTime from,DateTime to)
        {

            if (from >= to)
            {
                throw new WrongDateInterval("Tarixler duzgun daxil edilmeyib, xahis edirik yeniden cehd edesiz.");
            }

            for(int i = 0; i < Meetings.Length;i++)
            {
                if(from < Meetings[i].ToDate && to > Meetings[i].FromDate)
                {
                    throw new ReservedDateInterval("Artiq bele bir gorus movcuddur , xahis edirik yeniden cenhd edin.");
                }
            }
            Array.Resize(ref Meetings, Meetings.Length + 1);
            Meetings[^1] = new Meeting(from,to,fullName);
            Console.WriteLine("Meet yaradildi , her sey qaydasindadir");

        }
    

    
    }
}
