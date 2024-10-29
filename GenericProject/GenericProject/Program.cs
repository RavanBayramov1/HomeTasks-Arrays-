namespace GenericProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Elephant el = new Elephant(1500 , true,100,"Mamunt",800,Gender.Erkek);
            Wolf<Animal> alpha = new Wolf<Animal>(true, 500, 20, "Alpha", 100, Gender.Erkek);
            alpha.Hunt(el);

        }
    }
}
