using DesignPatterns.Dinosaur;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.AbstractFactory
{
    public class StegosaurusFactory : IDinosaurFactory
    {
        public IDinosaur CreateADinosaur()
        {
            return new Stegosaurus();
        }
    }
}
