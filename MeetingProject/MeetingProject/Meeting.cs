namespace MeetingProject
{
    public class Meeting
    {
        public DateTime FromDate { get; } 
        public DateTime ToDate { get; }
        public string FullName { get; set; }
        public Meeting(DateTime from, DateTime to, string fullName)
        {
            FromDate = from;
            ToDate = to;    
            FullName = fullName;
        }
    }
}
