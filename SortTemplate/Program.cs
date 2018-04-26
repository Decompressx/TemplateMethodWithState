using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortTemplate
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] mass = new int[5] { 1, 3, 2, 7, 5 };
            Algorithm algorithm = new Algorithm(new QuickSortAsc());
            algorithm.ExecuteAlgorithm(mass);

            foreach (var item in mass)
            {
                Console.Write(item+",");
            }

            Console.WriteLine();

            algorithm.ChangeStrategy(new BubbleSortDesc());
            algorithm.ExecuteAlgorithm(mass);

            foreach (var item in mass)
            {
                Console.Write(item + ",");
            }
            Console.ReadLine();
        }
    }
}
