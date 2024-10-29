namespace GenericProject;

internal class Meat : Food
{
    MeatType MeatType { get; set; }
    public Meat(int calorie, MeatType meatType)
    {
        MeatType = meatType;
        Calorie = calorie;
    }
}
enum MeatType
{
    Toyuq = 1,
    Deve = 2,
    QurbanliqQoyun = 3,
    Adam = 4
}
