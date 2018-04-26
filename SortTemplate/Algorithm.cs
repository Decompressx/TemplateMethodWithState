using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortTemplate
{
    public class Algorithm
    {
        int[] mass;
        AlgorithmBehavior algorithmBehavior { get; set; }

        public Algorithm(AlgorithmBehavior algorithmBehavior)
        {
            this.algorithmBehavior = algorithmBehavior;
        }

        public void ExecuteAlgorithm(int[] mass)
        {
            this.mass=mass;
            Call();
        }

        int[] Call()
        {
            return mass=algorithmBehavior.ExecuteAlgorithm(mass,0,mass.Length-1);
        }
        public void ChangeStrategy(AlgorithmBehavior algorithmBehavior)
        {
            this.algorithmBehavior=algorithmBehavior;
        }
    }
}
