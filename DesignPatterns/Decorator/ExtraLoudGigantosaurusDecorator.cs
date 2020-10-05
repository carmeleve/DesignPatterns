using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Decorator
{
    public class ExtraLoudGigantosaurusDecorator : IGigantosaurus
    {
        protected readonly IGigantosaurus gigantosaurus;

        public ExtraLoudGigantosaurusDecorator(IGigantosaurus gigantosaurus)
        {
            this.gigantosaurus = gigantosaurus;
        }

        public string Roar()
        {
            return $"{this.gigantosaurus.Roar()}!";
        }
    }
}
