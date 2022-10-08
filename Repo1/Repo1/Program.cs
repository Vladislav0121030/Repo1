using System;

namespace Repo1
{
    class Program
    {
        static void Main()
        {
            Console.Write("Введите год ");
            int? a = Convert.ToInt32(Console.ReadLine());
            if (a % 4 == 0)
            {
                Console.WriteLine("Год вискосный");
            }
            else
            {
                Console.WriteLine("Год невискосный");
            }
        }
    }
}
