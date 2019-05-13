using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns
{
    public class DinosaurExample : IDinosaurExample
    {
        public void MakeADinosaurNoise()
        {
            IDinosaur dinosaur = new TRex();
            dinosaur.MakeANoise();
        }
    }
}
