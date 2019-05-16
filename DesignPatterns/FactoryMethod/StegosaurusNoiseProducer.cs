using DesignPatterns.Dinosaur;

namespace DesignPatterns.FactoryMethod
{
    public class StegosaurusNoiseProducer : TRexNoiseProducer
    {
        public override IDinosaur MakeADinosaur()
        {
            return new Stegosaurus();
        }
    }
}
