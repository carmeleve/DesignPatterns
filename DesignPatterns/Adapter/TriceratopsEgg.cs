namespace DesignPatterns.Adapter
{
    public class TriceratopsEgg
    {
        public IChild Hatch()
        {
            return new TriceratopsChild();
        }
    }
}