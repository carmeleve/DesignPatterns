using System;

namespace DesignPatterns.Facade
{
    public class Soil
    {
        public int NutrientCount;

        public Soil(int nutrientCount)
        {
            Console.WriteLine($"The soil has {nutrientCount} nutrient(s)");
            this.NutrientCount = nutrientCount;
        }

        public void AddNutrient(Edible edible)
        {
            Console.WriteLine("The soil gains nutrients");
            edible.Eat();
            NutrientCount++;
            Console.WriteLine($"Nutrient count: {NutrientCount}");
        }

        public void UseNutrient()
        {
            if (NutrientCount <= 0)
            {
                throw new Exception("No nutrients left!");
            }
            NutrientCount--;
            Console.WriteLine($"Nutrient count: {NutrientCount}");
        }
    }
}