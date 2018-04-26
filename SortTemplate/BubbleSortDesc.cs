using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortTemplate
{
    public class BubbleSortDesc: BubbleSortTemplate
    {
        protected override bool Comparer(int a, int b)
        {
            if (a < b)
                return true;
            else
                return false;
        }

        protected override void Information()
        {
            Console.WriteLine("Выполняем сортировку пузырьком в обратном направлении");
        }
    }
}
