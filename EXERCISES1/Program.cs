using System;
using System.Collections.Generic;

namespace EXERCISES1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<double> numbers = new List<double> { 1.5, 2.5, 2.5, 3.2, 4.0, 4.0 };

            Console.WriteLine("Danh sach so ban dau: ");
            foreach (double num in numbers)
            {
                Console.Write(num+" ");
            }
            Console.WriteLine();

            for (int i = 0; i < numbers.Count - 1; i++)
            {
                if (numbers[i] == numbers[i + 1])
                {
                    numbers[i] = numbers[i] + numbers[i + 1];
                    numbers.RemoveAt(i + 1);
                    i--;
                }
            }

            Console.WriteLine("Ket qua tong cac so lien ke nhau:  ");
            foreach (double num in numbers)
            {
                Console.Write(num + " ");
            }
            Console.ReadLine();

        }
    }
}
