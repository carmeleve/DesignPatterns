using DesignPatterns.AbstractFactory;
using DesignPatterns.Builder;
using DesignPatterns.Dinosaur;
using DesignPatterns.FactoryMethod;
using System;

namespace DesignPatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            AbstractFactoryExamples("stegosaurus");
        }

        public static void AbstractFactoryExamples(string dinosaurType)
        {
            IDinosaurNoiseProducer af1 = new AbstractFactory.DinosaurNoiseProducer(new DinosaurFactory(dinosaurType));
            af1.MakeADinosaurNoise();
        }

        public static void FactoryMethodExamples()
        {
            IDinosaurNoiseProducer fm1 = new TRexNoiseProducer();
            fm1.MakeADinosaurNoise();

            IDinosaurNoiseProducer fm2 = new StegosaurusNoiseProducer();
            fm2.MakeADinosaurNoise();
        }

        public static void BuilderExample()
        {
            MealBuilder builder = new TRexMealBuilder();
            Meal meal = builder.BuildMeal();

            meal.ServeMeal();
        }
    }
}
