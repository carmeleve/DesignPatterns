namespace DesignPatterns.Adapter
{
    internal class TriceratopsChild : IChild
    {
        public void Cry()
        {
            System.Console.WriteLine("TRICERATOPS IS CRYING");
        }
    }
}