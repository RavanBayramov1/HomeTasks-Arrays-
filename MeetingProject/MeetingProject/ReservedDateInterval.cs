namespace MeetingProject
{
    public class ReservedDateInterval : Exception
    {
        public ReservedDateInterval(string message) : base(message) { }
    }

    public class WrongDateInterval : Exception
    {
        public WrongDateInterval(string message) : base(message) { }
    }
}
