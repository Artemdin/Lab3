using System;


namespace Lab3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
           int suma = CalcSumOfDivisors(n);
            Console.WriteLine($"Сума дільників: {suma}");
           
            PrintAllPerfectNumbers(n);
            PrintAllAmicableNumbersPairs(n);   
        }

        static int CalcSumOfDivisors(int sum)
        {
            int c = 0; // Для обчислення,**
            for (int i = 1; i <= sum / 2; i++)
            {
                if (sum % i == 0)
                {
                    c += i;
                }
            }
            return c;

        }

        static void PrintAllPerfectNumbers(int n)
        {
            Console.WriteLine("Досконалі числа в діапазоні [2, "+n+"]:");
            for (int i = 2; i <= n; i++)
            {
                if (CalcSumOfDivisors(i) == i)
                {
                    Console.WriteLine(i);


                }

            }
        }

       static void PrintAllAmicableNumbersPairs(int n)
        {
            Console.WriteLine("Дружні числа в діапазоні [2, " + n + "]:");
            for (int i = 2; i <= n; i++)
            {
                int b = CalcSumOfDivisors(i);
 
                if (b > i && b <= n && CalcSumOfDivisors(b) == i)
                {
                    Console.WriteLine($"({i}, {b})");




                }
            }
        }
    }
}