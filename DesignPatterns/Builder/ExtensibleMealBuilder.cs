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

        private readonly Meal meal = new Meal();

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
            this.addStarter(this.meal);
            this.addMain(this.meal);
            this.addDessert(this.meal);
            this.addToppings(this.meal);

            return meal;
        }
    }
}
