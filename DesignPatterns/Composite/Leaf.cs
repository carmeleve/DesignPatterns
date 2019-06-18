using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Composite
{
    public class Leaf : IPlant
    {
        public bool IsEaten { get; private set; } = false;
        public void Eat()
        {
            IsEaten = true;
            Console.WriteLine("Leaf eaten!");
        }
    }
}
