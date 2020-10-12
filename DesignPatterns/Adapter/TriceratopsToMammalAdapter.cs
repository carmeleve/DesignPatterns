using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Adapter
{
    public class TriceratopsToMammalAdapter : IMammal
    {
        private readonly Triceratops triceratops;

        public TriceratopsToMammalAdapter(Triceratops triceratops)
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
