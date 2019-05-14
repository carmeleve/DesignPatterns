using DesignPatterns.Dinosaur;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.AbstractFactory
{
    public class TRexFactory : IDinosaurFactory
    {
        public IDinosaur CreateADinosaur()
        {
            return new TRex();
        }
    }
}
