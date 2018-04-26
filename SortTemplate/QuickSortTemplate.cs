using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortTemplate
{
    public abstract class QuickSortTemplate : AlgorithmBehavior
    {
        int c;

        public override int[] ExecuteAlgorithm(int[] mass, int firstElem, int lastElem)
        {
            Information();
            quicksort(mass,firstElem,lastElem);
            return mass;
        }


        protected abstract void Information();
        protected abstract bool Comparer(int a, int b);

        int Partition(int[] m, int a, int b)
        {
            int i = a;
            for (int j = a; j <= b; j++)         
            {
                if (Comparer(m[j],(m[b])))
                {
                    int t = m[i];                  
                    m[i] = m[j];                 
                    m[j] = t;                   
                    i++;                         
                }
            }
            return i - 1;                        
        }
        void Recurse(int[] m, int a, int b)
        {
            quicksort(m, a, c - 1);
            quicksort(m, c + 1, b);
        }
        void quicksort(int[] m, int a, int b)
        {                                        
            if (a >= b) return;
            c = Partition(m, a, b);
            Recurse(m, a, b);
        }

    }
}
