using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Dinosaur
{
    public class Pterodactyl : IDinosaur
    {
        public void MakeANoise()
        {
            Console.WriteLine("CAWW!!");
        }
    }
}
