using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Composite
{
    public class Tree : IPlant
    {
        private readonly IList<Branch> branches;

        public Tree(IList<Branch> branches)
        {
            this.branches = branches;
        }

        public void Eat()
        {
            foreach (var branch in branches)
            {
                branch.Eat();
            }
        }
    }
}
