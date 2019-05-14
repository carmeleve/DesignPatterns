using System;

namespace DesignPatterns.Dinosaur
{
    public class Stegosaurus : IDinosaur
    {
        public void MakeANoise()
        {
            Console.WriteLine("Squeak?");
        }
    }
}