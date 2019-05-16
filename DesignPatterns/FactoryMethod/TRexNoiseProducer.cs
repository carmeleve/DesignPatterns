using DesignPatterns.Dinosaur;

namespace DesignPatterns.FactoryMethod
{
    public class TRexNoiseProducer : IDinosaurNoiseProducer
    {
        public void MakeADinosaurNoise()
        {
            IDinosaur dinosaur = MakeADinosaur();

            dinosaur.MakeANoise();
        }

        public virtual IDinosaur MakeADinosaur()
        {
            return new TRex();
        }
    }
}
