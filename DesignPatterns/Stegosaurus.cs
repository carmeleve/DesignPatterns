using System;

namespace DesignPatterns
{
    public class Stegosaurus : IDinosaur
    {
        public void MakeANoise()
        {
            Console.WriteLine("Squeak?");
        }
    }
}