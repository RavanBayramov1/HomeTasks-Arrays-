namespace GenericProject
{
    abstract class Animal
    {
        public Gender Gender { get; set; }
        public int AvgLifeTime {  get; set; }
        public string Breed {  get; set; }
        public int HP {  get; set; }
    }
    enum Gender
    {
        Erkek = 1,
        Disi = 2
    }
}
