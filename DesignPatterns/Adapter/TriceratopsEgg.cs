namespace DesignPatterns.Adapter
{
    public class TriceratopsEgg : IEgg
    {
        public IChild Hatch()
        {
            return new TriceratopsChild();
        }
    }
}