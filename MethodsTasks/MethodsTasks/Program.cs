//Task1

//using System.Numerics;
//using System.Security.Cryptography.X509Certificates;

//namespace MethodsTasks
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            Console.Write("Fiqurun sahesi: " + Area(6)+"-dir");
//        }
//            static float Area(float radius)
//            {
//                int p = 3;
//                float s = p * radius * radius;
//                return s;
//            }
//            static float Area(float length, float width)
//            {
//                return length * width;
//            }
//            static float Area(float length, float width, float height)
//            {
//                float s = 2 * (length * width + width * height + length * height);
//                return s;
//            }
//            static float Area(float a, float b, float c, float r)
//            {
//                float p = (a + b + c) / 2;
//                float s = p * r;
//                return s;
//            }
//        }
//    }

//Task2

//using System.Numerics;
//using System.Security.Cryptography.X509Certificates;

//namespace MethodsTasks
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            Console.Write("Cavab: " + Operators(5, 5, '-'));
//        }
//        static float Operators(float x, float y, char op)
//        {
//            if (op == '+')
//            {
//                float s = x + y;
//                ; return s;
//            }
//            else if (op == '-')
//            {
//                float s = x - y;
//                return s;
//            }
//            else if (op == '*')
//            {
//                float s = x * y;
//                return s;
//            }
//            else if (op == '/')
//            {
//                float s = x / y;
//                return s;
//            }
//            else
//            {
//                Console.WriteLine("Operator yanlisdir");
//            }
//            return 0;
//        }
//    }
//}

//Task3
//using System.Numerics;
//using System.Security.Cryptography.X509Certificates;

//namespace MethodsTasks
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            Console.Write("Cavab: " + Power(2 , 1));
//        }
//        static int Power(int num)
//        {
//            int numPow = num * num;
//            return numPow;
//        }
//        static int Power(int num , int pow)
//        {
//            int numPow = 1;
//            for (int i = 1;i <= pow; i++)
//            {
//                numPow *= num ;
//            }
//            return numPow;
//        }
//    }
//}


//Task4

//using System.Numerics;
//using System.Security.Cryptography.X509Certificates;

//namespace MethodsTasks
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            Console.Write(Info("Ravan" , "Bayramov"));
//        }
//        static string Info(string name)
//        {
//            return name;
//        }
//        static string Info(string name , string surname)
//        { 
//            return name + " " + surname;
//        }
//        static string Info(string name, string surname, string fatherName)
//        {
//            return name[0]+ ". " + surname + " " + fatherName;
//        }
//    }
//}

