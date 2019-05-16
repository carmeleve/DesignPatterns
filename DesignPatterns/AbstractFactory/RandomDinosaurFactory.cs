using System;
using System.Collections.Generic;
using System.Text;
using DesignPatterns.Dinosaur;

namespace DesignPatterns.AbstractFactory
{
    public class RandomDinosaurFactory : IDinosaurFactory
    {
        private Random random;

        public RandomDinosaurFactory(Random random)
        {
            this.random = random;
        }

        public IDinosaur CreateADinosaur()
        {
            int randomNumber = random.Next(0, 10);

            if (randomNumber < 5)
            {
                return new TRex();
            }
            else
            {
                return new Stegosaurus();
            }
        }
    }
}
