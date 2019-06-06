using DesignPatterns.Dinosaur;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Builder
{
    public class ExtensibleMealBuilder
    {
        private readonly Action<Meal> addStarter;
        private readonly Action<Meal> addMain;
        private readonly Action<Meal> addDessert;
        private readonly Action<Meal> addToppings;

        public ExtensibleMealBuilder(
            Action<Meal> addStarter, 
            Action<Meal> addMain, 
            Action<Meal> addDessert, 
            Action<Meal> addToppings)
        {
            this.addStarter = addStarter;
            this.addMain = addMain;
            this.addDessert = addDessert;
            this.addToppings = addToppings;
        }

        public Meal BuildMeal()
        {
            Meal meal = new Meal();
            this.addStarter(meal);
            this.addMain(meal);
            this.addDessert(meal);
            this.addToppings(meal);

            return meal;
        }
    }
}
