namespace GenericProject;

internal class Grass : Food
{
    public string Name { get; set; }
    public Grass(string name , int calorie)
    {
        Name = name;
        Calorie = calorie;
    }
}
