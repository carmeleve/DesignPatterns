using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Builder
{
    public class TRexMealBuilder : MealBuilder
    {
        protected override void AddStarter()
        {
            this.meal.Starter = "A bit of meat";
        }
        protected override void AddMain()
        {
            this.meal.MainCourse = "Some more meat";
        }
        protected override void AddDessert()
        {
            this.meal.Dessert = "Even more meat";
        }
        protected override void AddToppings()
        {
            this.meal.AddTopping("Meat");
            this.meal.AddTopping("More meat");
        }
    }
}
