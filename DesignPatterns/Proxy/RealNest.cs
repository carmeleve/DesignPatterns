using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Proxy
{
    public class RealNest : INest
    {
        public void Access(string name)
        {
            Console.WriteLine($"{name} has access to the nest");
        }
    }
}
