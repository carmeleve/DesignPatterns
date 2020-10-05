using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Adapter
{
    public class Triceratops
    {
        public TriceratopsEgg LayEgg()
        {
            return new TriceratopsEgg();
        }
    }
}
