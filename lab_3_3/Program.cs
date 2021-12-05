using System;

namespace lab_3_3
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Введите n:");
                int n = int.Parse(Console.ReadLine());
                Console.WriteLine("Введите x:");
                double x = double.Parse(Console.ReadLine());
                double h = 0;
                double S = 0;
                for (int i = 1; i <= n; i++)
                {
                    long F = 1;
                    for (int j = 1; j < 2 * i - 1; j++) F *= j;
                    S += (Math.Pow(x, 2 * i - 1) / (2 * i - 1)!) / F;
                    
                }
                h = x - S;
                Console.WriteLine("h={0:F2}", h);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
