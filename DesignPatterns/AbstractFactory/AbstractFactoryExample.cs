using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.AbstractFactory
{
    public class AbstractFactoryExample : IDinosaurExample
    {
        private IDinosaurFactory thingFactory;

        public AbstractFactoryExample(IDinosaurFactory thingFactory)
        {
            this.thingFactory = thingFactory;
        }

        public void MakeADinosaurNoise()
        {
            IDinosaur thing = this.thingFactory.CreateADinosaur();
            thing.MakeANoise();
        }
    }
}
