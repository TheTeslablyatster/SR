using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SR
{
    class Program
    {
        static void For12()
        {
            double N = double.Parse(Console.ReadLine());
            double Ans = 0;
            for (int i = 1; i <= N; i++)
            {
                string help = "1." + N.ToString();
                _ = N % 2 == 1 ? Ans = Ans + double.Parse(help) : Ans = Ans - double.Parse(help);
            }
            Console.WriteLine(Ans);
        }

        static double Factorial(double a)
        {
            double ans = 1;
            for (int i = 1; i <= a; i++)
                ans = ans * i;
            return ans;
        }

        static void For20()
        {
            double N = double.Parse(Console.ReadLine());
            double Ans = 0;
            for (int i = 1; i <= N; i++)
                Ans = Ans + Factorial(i);
            Console.WriteLine(Ans);
        }

        static void For34()
        {
            double N = double.Parse(Console.ReadLine());
            double Grandparent = 1;
            double Parent = 2;
            double Son;
            Console.Write($"{Grandparent} {Parent} ");
            for (int i = 0; i < N - 2; i++)
            {
                Son = Grandparent = 2 * Parent;
                Console.Write($"{Son} ");
                Grandparent = Parent;
                Parent = Son;
            }
        }

        static void While4()
        {
            int N = int.Parse(Console.ReadLine());
            while (N > 3)
                N = N / 3;
            string Ans = N != 3 ? "TRUE" : "False";
            Console.WriteLine(Ans);
        }

        static void While12()
        {
            int N = int.Parse(Console.ReadLine());
            int Sum = 0;
            int K = 0;
            while (Sum <= N)
            {
                K += 1;
                Sum += K; 
            }
            Console.WriteLine($"{K} {Sum}");
        }

        static void While23()
        {
            int A = int.Parse(Console.ReadLine());
            int B = int.Parse(Console.ReadLine());

        }

        static void Series21()
        {
            int N = int.Parse(Console.ReadLine());
            var Line = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();
            bool Ans = true;
            for (int i = 1; i < N; i++)
                if (Line[i] < Line[i - 1])
                    Ans = false;
            Console.WriteLine(Ans.ToString().ToUpper());
        }


        static bool IsLeapYear(int year)
        {
            if (year % 100 == 0 || year % 400 == 0)
            {
                Console.Write("FALSE");
                return false;
            }
            if (year % 4 == 0)
            {
                Console.Write("TRUE");
                return true;
            }
            Console.Write("FALSE");
            return false;
        }
        static void Proc52()
        {
            var Years = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            foreach (var year in Years)
                IsLeapYear(year);
        }

        static void MinMax12()
        {

        }

        static void Array16()
        {
            var Array = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            for (int i = 0; i < Array.Length / 2; i++)
                Console.Write($"{Array[i]} {Array[Array.Length - i]} ");
        }

        static void Array47()
        {

        }

        static void Array68()
        {

        }

        static void Array76()
        {

        }

        static void Array110()
        {

        }


        static void Main(string[] args)
        {
        }
    }
}
