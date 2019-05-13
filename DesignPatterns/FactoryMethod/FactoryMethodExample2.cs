using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.FactoryMethod
{
    public class FactoryMethodExample2 : FactoryMethodExample
    {
        public override IDinosaur MakeAThing()
        {
            return new Stegosaurus();
        }
    }
}
