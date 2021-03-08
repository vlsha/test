using System;

namespace lab3
{
    internal class Program
    {

        static double option1(double x, double a, double b, double c)
        {
            double F;

            if (c < 0 && x != 0)
            {
                F = -a * x - c;
            }
            else
            {
                if (c > 0 && b == 0)
                {
                    F = (x - a) / -c;
                }
                else
                {
                    F = b * x / (c - a);
                }
            }

            return F;
        }

        static double option2(double n)
        {
            double sum = 0;
            for (double i = 1; i <= n; i++)
                if (i % 5 != 0)
                    sum += 1 / i * i;

            return sum;
        }

        static long option3(int n)
        {
            int sum = 0;
            for (int i = 1; i <= n; i++)
            for (int j = 1; j <= i; j++)
                sum += j;
            return sum;
        }

        public static void Main(string[] args)
        {
            bool flag = true;
            while (flag == true)
            {
                Console.WriteLine("0 - Exits. Select option: ");
                int choice = Int32.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 0:
                        flag = false;
                        break;
                    case 1:
                        Console.WriteLine("Enter x:");
                        double x = Double.Parse(Console.ReadLine());
                        Console.WriteLine("Enter a:");
                        double a = Double.Parse(Console.ReadLine());
                        Console.WriteLine("Enter b:");
                        double b = Double.Parse(Console.ReadLine());
                        Console.WriteLine("Enter c:");
                        double c = Double.Parse(Console.ReadLine());
                        Console.WriteLine(option1(x, a, b, c));
                        break;
                    case 2:
                        Console.WriteLine("Enter n:");
                        double n = double.Parse(Console.ReadLine());
                        double z = option2(n);
                        Console.WriteLine(z);
                        break;
                    case 3:
                        Console.Write("I=");
                        int i = int.Parse(Console.ReadLine());
                        Console.WriteLine(option3(i));
                        break;
                    default:
                        Console.WriteLine("Error");
                        break;
                }
            }
        }
    }
}