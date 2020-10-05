using DesignPatterns.AbstractFactory;
using DesignPatterns.Builder;
using DesignPatterns.Composite;
using DesignPatterns.Decorator;
using DesignPatterns.Dinosaur;
using DesignPatterns.FactoryMethod;
using System;
using System.Collections.Generic;
using System.Linq;

namespace DesignPatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            DecoratorExample();
        }

        public static void DecoratorExample()
        {
            var gigantosaurus = new Gigantosaurus();

            Console.WriteLine(gigantosaurus.Roar());

            var loudGigantosaurus = new LoudGigantosarusDecorator(gigantosaurus);
            var extraLoudGigantosaurus = new ExtraLoudGigantosaurusDecorator(loudGigantosaurus);

            Console.WriteLine(extraLoudGigantosaurus.Roar());
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

        static void CreateAMealExample()
        {
            var meal = new Meal();

            meal.Starter = "a few green leaves";
            meal.MainCourse = "a huge plate of ferns";
            meal.SetDessert("fruit and berries");

            meal.ServeMeal();
        }

        public static void BuilderExample()
        {
            MealBuilder builder = new StegosaurusMealBuilder();
            Meal meal = builder.BuildMeal();

            meal.ServeMeal();
        }

        public static void CompositeExample()
        {
            var plants = new List<IPlant>();

            var branch = new Branch(new List<IPlant>() { new Leaf(), new Leaf() });
            var anotherBranch = new Branch(new List<IPlant>() { new Leaf(), new Leaf(), new Leaf(), new Leaf() });

            plants.Add(new Branch(
                new List<IPlant>()
                    { branch, anotherBranch }
            ));

            plants.Add(new Leaf());
            plants.Add(new Branch(new List<IPlant>() { new Leaf(), new Leaf(), new Leaf(), new Leaf(), new Leaf() }));
            plants.Add(new Leaf());

            foreach (IPlant plant in plants)
            {
                plant.Eat();
            }
            
        }
    }
}
