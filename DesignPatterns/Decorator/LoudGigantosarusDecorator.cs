using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Decorator
{
    public class LoudGigantosarusDecorator : IGigantosaurus
    {
        protected readonly IGigantosaurus gigantosaurus;

        public LoudGigantosarusDecorator(IGigantosaurus gigantosaurus)
        {
            this.gigantosaurus = gigantosaurus;
        }

        public string Roar()
        {
            return $"{this.gigantosaurus.Roar()} loudly";
        }
    }
}
