using DesignPatterns.Dinosaur;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Builder
{
    public abstract class MealBuilder
    {
        protected Meal meal = new Meal();

        public Meal BuildMeal()
        {
            AddStarter();
            AddMain();
            AddDessert();
            AddToppings();

            return meal;
        }

        protected abstract void AddStarter();
        protected abstract void AddMain();
        protected abstract void AddDessert();
        protected abstract void AddToppings();
    }
}
