using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortTemplate
{
    public abstract class BubbleSortTemplate : AlgorithmBehavior
    {
        public override int[] ExecuteAlgorithm(int[] mass, int firstElem, int lastElem)
        {
            Information();
            BubbleSort(mass);
            return mass;
        }

        protected abstract void Information();
        protected abstract bool Comparer(int a, int b);

        void BubbleSort(int[] mass)
        {
            for (int i = 0; i < mass.Length; i++)
            {
                for (int j = 0; j < mass.Length - i - 1; j++)
                {
                    if (Comparer(mass[j], mass[j + 1]))
                    {
                        int temp = mass[j];
                        mass[j] = mass[j + 1];
                        mass[j + 1] = temp;
                    }
                }
            }
        }
    }
}
