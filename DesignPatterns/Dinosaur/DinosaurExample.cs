namespace DesignPatterns.Dinosaur
{
    public class DinosaurExample : IDinosaurExample
    {
        public void MakeADinosaurNoise()
        {
            IDinosaur dinosaur = new TRex();
            dinosaur.MakeANoise();
        }
    }
}
