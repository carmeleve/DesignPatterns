using DesignPatterns.Dinosaur;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.AbstractFactory
{
    public class AbstractFactoryExample : IDinosaurExample
    {
        private IDinosaurFactory dinosaurFactory;

        public AbstractFactoryExample(IDinosaurFactory dinosaurFactory)
        {
            this.dinosaurFactory = dinosaurFactory;
        }

        public void MakeADinosaurNoise()
        {
            IDinosaur dinosaur = this.dinosaurFactory.CreateADinosaur();
            dinosaur.MakeANoise();
        }
    }
}
