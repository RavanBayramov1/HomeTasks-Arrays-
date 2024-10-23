namespace Indexer_Array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ListInt a = new ListInt();
            a.Add(1);
            a.Add(2);
            a.Add(3);
            a.Add(new int[] { 4, 5, 6, 7 });
            a.Pop();
            Console.WriteLine(a.Contains(41));
        }
    }
}
