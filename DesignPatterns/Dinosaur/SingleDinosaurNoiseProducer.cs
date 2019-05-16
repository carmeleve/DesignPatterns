namespace DesignPatterns.Dinosaur
{
    public class SingleDinosaurNoiseProducer : IDinosaurNoiseProducer
    {
        public void MakeADinosaurNoise()
        {
            IDinosaur dinosaur = new TRex();
            dinosaur.MakeANoise();
        }
    }
}
