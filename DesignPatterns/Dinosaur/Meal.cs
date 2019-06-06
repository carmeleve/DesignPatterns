using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Dinosaur
{
    public class Meal
    {
        public string Starter { get; set; }

        public string MainCourse { get; set; }

        private Dessert Dessert;

        public void AddTopping(string topping)
        {
            Dessert.AddTopping(topping);
        }

        public void SetDessert(string dessertName)
        {
            Dessert = new Dessert(dessertName);
        }

        public void ServeMeal()
        {
            Console.WriteLine($"Bringing you {Starter}, " +
                $"then {MainCourse}, " +
                $"then {Dessert.Name} with {Dessert.ListToppings()} on top");
        }
    }
}
