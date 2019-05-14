using DesignPatterns.AbstractFactory;
using DesignPatterns.Dinosaur;
using DesignPatterns.FactoryMethod;
using System;

namespace DesignPatters
{
    class Program
    {
        static void Main(string[] args)
        {
            AbstractFactoryExamples();
        }

        public static void AbstractFactoryExamples()
        {
            IDinosaurExample af1 = new AbstractFactoryExample(new TRexFactory());
            af1.MakeADinosaurNoise();

            IDinosaurExample af2 = new AbstractFactoryExample(new StegosaurusFactory());
            af2.MakeADinosaurNoise();
        }

        public void FactoryMethodExamples()
        {
            IDinosaurExample fm1 = new FactoryMethodExample();
            fm1.MakeADinosaurNoise();

            IDinosaurExample fm2 = new FactoryMethodExample2();
            fm2.MakeADinosaurNoise();
        }
    }
}
