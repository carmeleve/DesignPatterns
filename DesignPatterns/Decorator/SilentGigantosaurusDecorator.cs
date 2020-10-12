using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Decorator
{
    public class SilentGigantosaurusDecorator : IGigantosaurus
    {
        protected readonly IGigantosaurus gigantosaurus;

        public SilentGigantosaurusDecorator(IGigantosaurus gigantosaurus)
        {
            this.gigantosaurus = gigantosaurus;
        }

        public string Roar()
        {
            return "";
        }
    }
}
