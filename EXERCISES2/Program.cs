using System;
using System.Collections.Generic;

namespace EXERCISES2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18 };
            Console.WriteLine("Dand sach so ban dau: ");
            foreach (int num in list)
            {
                Console.Write(num+" ");
            }
            Console.WriteLine();

            int first = 0, last = list.Count - 1;
            int sum = 0;

            for (int i = 0; i < list.Count / 2; i++)
            {
                sum += list[first++] + list[last--];
                {
                    sum += list[first++] + list[last--];
                }
            }
            Console.WriteLine("tong tat ca cac so da cho: "+sum);
            Console.ReadLine();
        }
    }
}
