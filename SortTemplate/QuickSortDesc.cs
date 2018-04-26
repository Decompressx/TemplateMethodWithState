using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortTemplate
{
    public class QuickSortDesc : QuickSortTemplate
    {
        protected override void Information()
        {
            Console.WriteLine("Выполняем быструю сортировку в обратном направлении");
        }
        protected override bool Comparer(int a, int b)
        {
            if (a.CompareTo(b) >= 0)
                return true;
            else
                return false;
        }
    }
}
