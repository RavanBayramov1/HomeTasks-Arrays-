namespace SingerSongTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Adi daxil edin: ");
            string singerName = Console.ReadLine();
            Console.WriteLine("Soyadi daxil edin: ");
            string singerSurname = Console.ReadLine();
            Console.WriteLine("Yasi daxil edin: ");
            int age = Convert.ToInt32(Console.ReadLine());
            Singer singer = new Singer(singerName, singerSurname, age);
            Console.WriteLine("Musiqinin adini daxil edin: ");
            string songName = Console.ReadLine();
            Console.WriteLine("Janri daxil edin: ");
            string genre = Console.ReadLine();
            Song song = new Song(songName, genre,singer);
            song.AddRating(4.5);
            song.AddRating(5.5);
            song.GetAverageRating();
        }
    }
}
    
