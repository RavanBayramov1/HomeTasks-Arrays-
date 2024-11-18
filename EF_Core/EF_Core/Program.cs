using EF_Core.Context;
using EF_Core.Exceptions;
using EF_Core.Models;
using Microsoft.EntityFrameworkCore.Infrastructure.Internal;

namespace EF_Core
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Users> users = [];
            List<Products> products = [];
            List<Baskets> baskets = [];

            using (AppDBContext context = new AppDBContext())
            {
                while (true)
                {
                    Console.WriteLine("Make a choice:");
                    Console.WriteLine("1." +
                        "=> Register <=");
                    Console.WriteLine("2." +
                        "=> Login <=");
                    int choice = int.Parse(Console.ReadLine());
                    switch (choice) {
                        case 1:
                           
                                Console.WriteLine("Name: ");
                                string name = Console.ReadLine();
                                Console.WriteLine("Surname: ");
                                string surname = Console.ReadLine();
                                Console.WriteLine("Username: ");
                                string username = Console.ReadLine();
                                Console.WriteLine("Password: ");
                                string password = Console.ReadLine();
                                var user = context.Users.ToList().Find(x => x.Username == username);
                            if (user is null)
                            {
                                context.Users.Add(new Users
                                {
                                    Name = name,
                                    Surname = surname,
                                    Username = username,
                                    Password = password

                                });
                                context.SaveChanges();
                                Console.WriteLine("----------------------------");
                                Console.WriteLine("Successful registeration!");
                                Console.WriteLine("----------------------------");
                                //break;
                            }
                            else
                            {
                                throw new UserExistException();  
                            }
                            break;
                        case 2:
                            
                            Console.WriteLine("Username: ");
                            string usrnm= Console.ReadLine();
                            Console.WriteLine("Password: ");
                            string pswrd= Console.ReadLine();
                            var user2 = context.Users.Where(x => x.Username == usrnm && x.Password == pswrd).FirstOrDefault();
                            if(user2 is null)
                            {
                                throw new UserNotFoundException();
                            }
                            Console.WriteLine("Succesful login!");
                            bool isTrue = true;
                            while (isTrue)
                            {
                                Console.WriteLine("""
                                    1. => Review the products <=
                                    2. => Review the basket <=
                                    3. => Exit <=
                                    """);
                                int choice2 = int.Parse(Console.ReadLine());
                                switch (choice2)
                                {
                                    case 1:
                                        products = context.Products.ToList();
                                        products.ForEach(x=> Console.WriteLine(x.Id+". "+ x.Name + " - " + x.Price+" manat"));
                                        int id = int.Parse(Console.ReadLine());
                                        var prd = context.Products.Where(x => x.Id==id).FirstOrDefault();
                                        if (id == 0)
                                        {
                                            break;
                                        }

                                        else if(prd is null)
                                        {
                                            throw new ProductNotFoundException();
                                        }
                                        context.Baskets.Add(new Baskets
                                        {
                                            UserId = user2.Id,
                                            ProductId = prd.Id,
                                        });

                                        context.SaveChanges();
                                        Console.WriteLine("Product added to basket");
                                        break;
                                    case 2:
                                        baskets = context.Baskets.Where(x => x.UserId == user2.Id).ToList();

                                        foreach (var bask in baskets)
                                        {
                                            var prd2 = context.Products.Where(x => x.Id == bask.ProductId).FirstOrDefault();
                                            Console.WriteLine(prd2.Id + ". " + prd2.Name + " - " + prd2.Price + " manat");
                                        }

                                        Console.WriteLine("Add Id for remove from basket");
                                        int delete = int.Parse(Console.ReadLine());

                                        var data = context.Baskets.Where(x => x.UserId == user2.Id && x.ProductId == delete).FirstOrDefault();

                                        if (data is null)
                                        {
                                            throw new ProductNotFoundException(); 
                                        }
                                        context.Baskets.Remove(data);
                                        Console.WriteLine("Product removed");
                                        context.SaveChanges();
                                        break;
                                    case 3:
                                        isTrue = false;
                                        break;
                                    default:
                                        Console.WriteLine("Wrong choice!");
                                        break;
                                }
                            }
                            break;
                        default:
                            Console.WriteLine("Wrong choice!");
                            break;
                    }
                }

            }
        }
    }
}
