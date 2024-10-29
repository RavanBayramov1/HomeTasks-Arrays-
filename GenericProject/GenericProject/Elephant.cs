namespace GenericProject;

internal class Elephant : Animal
{
    public double Weight { get; set; }
    public bool IsTrained { get; set; }
    public Elephant(double weight, bool isTrained, int avgLifeTime, string breed, int hp, Gender gender)
    {
        Weight = weight;
        IsTrained = isTrained;
        AvgLifeTime = avgLifeTime;
        Breed = breed;
        HP = hp;
        Gender = gender;

    }
}
