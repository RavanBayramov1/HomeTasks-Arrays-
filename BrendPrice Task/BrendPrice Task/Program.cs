namespace BrendPrice_Task
{
    public class Program
    {
        static void Main(string[] args)
        {
            Product Yag = new Product("Kere yag", "Anchor", 17.55);
            Product Duyu = new Product("Basmati", "Sultan", 8.79);
            Product Sud = new Product("2.5%li", "AzerSud", 1.65);
            Product Cay = new Product("Earl Grey", "AzerCay", 6.2);
            Product Salfetka = new Product("Tualet Kagizi", "Aura", 24.9);
            Product[] Products = {Yag, Cay, Sud, Duyu, Salfetka};
            ProductFilter(Products,30,0);
        }
        static void ProductFilter(Product[] Products, double MaxPrice, double MinPrice)
        {
            bool have = false;
            for (int i = 0; i < Products.Length; i++)
            {
                if (Products[i].Price < MaxPrice && Products[i].Price > MinPrice)
                {
                    have = true;
                    Console.WriteLine(Products[i].BrandName + " " + Products[i].Price);
                }

            }
            if (!have)
            {
                Console.WriteLine("Mehsul tapilmadi!");
            }
        }
    }
}
