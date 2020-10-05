using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Adapter
{
    public class TriceratopsAdapter : IMammal
    {
        private readonly Triceratops triceratops;

        public TriceratopsAdapter(Triceratops triceratops)
        {
            this.triceratops = triceratops;
        }

        public IChild GiveBirth()
        {
            TriceratopsEgg egg = triceratops.LayEgg();

            IChild child = egg.Hatch();

            return child;
        }
    }
}
