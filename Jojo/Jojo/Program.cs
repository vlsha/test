using System;

namespace Jojo
{
    internal class Program
    {
        
        static int option1(int x)
        {
            int multiplication1 = x * x * x;
            int multiplication2 = multiplication1 * multiplication1;
            int multiplication3 = multiplication2 * x;
            
            return multiplication3;

        }
        
        static double option2(double z)
        {
            double result = (z * 10) % 10;

            return result;
        }
        

        static double op3(double m, double n, double p,
            double a, double b, double c, double d, double e)
        {
            double x0 = b * c / Math.Pow(d, m); //1+5+7+13
            double x4 = Math.Cos(x0); //1+13
            double x1 = Math.Sin(a); //1+13
            double x2 = Math.Pow(2, n) * (x1 * x1 - x4 * x4); //1+13+5+5+3+5
            double x3 = Math.Log(Math.Pow(a + x0, 1 / 3)) - e / Math.Pow(2, p);
            //13+13+3+3+7+13+1
            double result = x2 / x3; //1+7
            return result; //147
        }
        
        
        public static void Main(string[] args)
        {
            bool flag = true;

            while (flag == true)
            {
                Console.WriteLine("0 - exit. select option:");
                int choice = Int32.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                    {
                        Console.WriteLine("Enter x:");
                        int x = int.Parse(Console.ReadLine());
                        Console.WriteLine("result3 = " + option1(x));
                        break;
                    }
                    case 2:
                    {
                        Console.WriteLine("Enter z:");
                        double z = double.Parse(Console.ReadLine());
                        Console.WriteLine("result3 = " + option2(z));
                        break;
                    }
                    case 3:
                    {
                        Console.WriteLine("Enter m:");
                        double m = double.Parse(Console.ReadLine());
                        Console.WriteLine("Enter n:");
                        double n = double.Parse(Console.ReadLine());
                        Console.WriteLine("Enter p:");
                        double p = double.Parse(Console.ReadLine());
                        Console.WriteLine("Enter a:");
                        double a = double.Parse(Console.ReadLine());
                        Console.WriteLine("Enter b:");
                        double b = double.Parse(Console.ReadLine());
                        Console.WriteLine("Enter c:");
                        double c = double.Parse(Console.ReadLine());
                        Console.WriteLine("Enter d:");
                        double d = double.Parse(Console.ReadLine());
                        Console.WriteLine("Enter e:");
                        double e = double.Parse(Console.ReadLine());
                        double z = op3(m, n, p, a, b, c, d, e);
                        Console.WriteLine(z);
                        break;
                    }
                    case 4:
                    {
                        double d_t_rate = 1 / 8.0; // gbyte/s
                        double V_dog = 12 * 1000 / 3600; // m/s
                        double vol_disk = 1024; // gbyte
                        double dist = (vol_disk * V_dog) / d_t_rate; // minimal distance
                        Console.WriteLine("Расстояние между офисами должно превышать " + dist / 1000 + " км.");
                        break;
                    }
                    case 0:
                    {
                        flag = false;
                        break;
                    }
                    default:
                        Console.WriteLine("Default case");
                        break;
                }
            }
        }
    }
}