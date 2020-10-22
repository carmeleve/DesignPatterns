using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Facade
{
    public class Herbivore : Edible
    {
        public Herbivore(Plant plant)
        {
            Console.WriteLine("The herbivore eats a plant.");
            plant.Eat();
            IsEaten = false;
        }
    }
}
