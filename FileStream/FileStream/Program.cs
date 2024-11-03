using System.Text.Json.Serialization;
using FileStream.Models;
using FileStream.Service;

namespace FileStream
{
    public class Program
    {
        static void Main(string[] args)
        {
            FileHelper hp = new FileHelper(@"C:\Users\99450\Desktop\FileStream\FileStream\Json\names.json");
            hp.Add("Ravan");
            hp.Add("Farid");
            hp.Add("Ulvi Mellim");
            Console.WriteLine(hp.Exist("Ravan"));
            hp.Delete(1);
            hp.Update(0, "Farid");
        }
    }
}
