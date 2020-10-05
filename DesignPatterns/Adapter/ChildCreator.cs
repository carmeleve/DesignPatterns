using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Adapter
{
    public static class ChildCreator
    {
        public static IChild CreateChild(IMammal mammal)
        {
            return mammal.GiveBirth();
        }
    }
}
