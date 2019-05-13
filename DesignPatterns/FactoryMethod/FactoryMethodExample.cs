using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.FactoryMethod
{
    public class FactoryMethodExample : IDinosaurExample
    {
        public void MakeADinosaurNoise()
        {
            IDinosaur dinosaur = MakeADinosaur();

            dinosaur.MakeANoise();
        }

        public virtual IDinosaur MakeADinosaur()
        {
            return new TRex();
        }
    }
}
