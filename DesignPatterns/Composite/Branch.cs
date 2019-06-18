using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Composite
{
    public class Branch : IPlant
    {
        private readonly IList<Leaf> leaves = new List<Leaf>();

        public Branch(int numberOfLeaves)
        {
            for (int i = 0; i < numberOfLeaves; i++)
            {
                leaves.Add(new Leaf());
            }
        }
        public void Eat()
        {
            foreach (var leaf in leaves)
            {
                leaf.Eat();
            }
        }
    }
}
