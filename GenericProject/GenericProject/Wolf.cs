namespace GenericProject
{
    internal class Wolf <T> : Animal where T : Animal
    {
        public int AttackDamage {  get; set; }
        public bool IsPrideLeader {  get; set; }
        public Wolf(bool isPrideLeader , int attackDamage, int avgLifeTime, string breed, int hp , Gender gender)
        {
            AttackDamage = attackDamage;
            IsPrideLeader = isPrideLeader;
            AvgLifeTime = avgLifeTime;
            Breed = breed;  
            HP = hp;
            Gender = gender;
        }
        public void Hunt(T animal)
        {
            if (animal.HP > AttackDamage)
            {
                animal.HP = animal.HP - AttackDamage;
                Console.WriteLine("Qalan HP: "+animal.HP);
            }
            else
            {
                animal.HP = 0;
                Console.WriteLine("Bu heyvan geberdi!");
            }
        }
    }
}
