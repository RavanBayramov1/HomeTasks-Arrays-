namespace LibraryMicroProject.Exceptions
{
    internal class CustomLibraryException : Exception
    {
        public CustomLibraryException() : base("This book already exists")
        {

        }

        public CustomLibraryException(string message) : base(message)
        {
        }
    }
}
