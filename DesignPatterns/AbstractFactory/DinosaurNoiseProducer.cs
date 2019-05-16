using DesignPatterns.Dinosaur;
using System;

namespace DesignPatterns.AbstractFactory
{
    public class DinosaurNoiseProducer : IDinosaurNoiseProducer
    {
        private IDinosaurFactory dinosaurFactory;

        public DinosaurNoiseProducer(IDinosaurFactory dinosaurFactory)
        {
            this.dinosaurFactory = dinosaurFactory;
        }

        public void MakeADinosaurNoise()
        {
            IDinosaur dinosaur = this.dinosaurFactory.CreateADinosaur();

            if (dinosaur != null)
            {
                dinosaur.MakeANoise();
            }
        }
    }
}
