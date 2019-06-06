using DesignPatterns.Dinosaur;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Builder
{
    public class StegosaurusMealBuilder : MealBuilder
    {
        protected override void AddStarter()
        {
            this.meal.Starter = "a few green leaves";
        }

        protected override void AddMain()
        {
            this.meal.MainCourse = "a huge plate of ferns";
        }

        protected override void AddDessert()
        {
            this.meal.SetDessert("fruit and berries");
        }

        protected override void AddToppings()
        {
            this.meal.AddTopping("crunchy flowers");
        }
    }
}
