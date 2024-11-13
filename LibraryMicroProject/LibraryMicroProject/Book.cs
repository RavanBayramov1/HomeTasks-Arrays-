namespace LibraryMicroProject
{
    internal class Book
    {
        private static int _no;
        public int No { get; }
        public string Name { get; set; }
        public string AuthorName { get; set; }
        public float Price { get; set; }
        public Book(string name, string authorName,float price)
        {
            No = ++_no;
            Name = name;
            AuthorName = authorName;
            Price = price;
        }
        public void ShowInfo()
        {
            Console.WriteLine($"ID:{No} - Name: {Name} - AuthorName: {AuthorName} - Price: {Price}");
        }
    }
}
