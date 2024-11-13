using LibraryMicroProject.Exceptions;
using System.Collections.Generic;
using System.Text.Json.Serialization;
namespace LibraryMicroProject
{
    internal class Library
    {
        private static int _id;
        public int Id {get; }
        public string Name { get; set; }
        public string Path { get; set; }
        List<Book> Books = [];
        //string str;
        public Library(string name ,string path)
        {
            Id = ++_id;
            Name = name;
            Path = path;   
        }
        public void AddBook(Book book)
        {
            Books = Read(Path);
            if (Books.Contains(book))
            {
                throw new CustomLibraryException();
            }
            else
            {
                Books.Add(book);
                Console.WriteLine("Elave edildi!");
            }
            Writer(Books);

        }
        public Book GetBookById(int id)
        {
            Book book = Books.Find(x => x.No == id);
            if(book is null) 
            {
                throw new CustomLibraryException("This book does not exist");
            }
            return Books[id];
        }
        public void RemoveBook(Book book)
        {
            Books = Read(Path);
            if (Books.Contains(book))
            {
                Books.Remove(book);
            }
            else
            {
                throw new CustomLibraryException("This book does not exist");
            }
            Writer(Books);
        }
        public void Writer(List<Book> text)
        {
            using StreamWriter sw = new StreamWriter(Path,false);
            sw.WriteLine(JsonConvert.SerializeObject(text));
        }
        public List<Book> Read(string path)
        {
            using StreamReader sr = new StreamReader(Path);
            sr.
        }
    }
}
