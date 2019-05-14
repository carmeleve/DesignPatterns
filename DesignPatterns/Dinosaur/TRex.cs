using System;

namespace DesignPatterns.Dinosaur
{
    public class TRex : IDinosaur
    {
        public void MakeANoise()
        {
            Console.WriteLine("RAWWR!");
        }
    }
}