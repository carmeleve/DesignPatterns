using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Decorator
{
    public class Gigantosaurus : IGigantosaurus
    {
        public string Roar()
        {
            return "ROAR";
        }
    }
}
