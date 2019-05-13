using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.FactoryMethod
{
    public class FactoryMethodExample : IDinosaurExample
    {
        public void MakeADinosaurNoise()
        {
            IDinosaur thing = MakeAThing();

            thing.MakeANoise();
        }

        public virtual IDinosaur MakeAThing()
        {
            return new TRex();
        }
    }
}
