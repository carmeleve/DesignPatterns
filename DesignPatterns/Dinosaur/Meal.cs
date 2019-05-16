using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Dinosaur
{
    public class Meal
    {
        public string Starter { get; set; }

        public string MainCourse { get; set; }

        public string Dessert { get; set; }

        private readonly IList<string> toppings = new List<string>();

        public void AddTopping(string topping)
        {
            toppings.Add(topping);
        }

        public void ServeMeal()
        {
            Console.WriteLine($"Bringing you {Starter}, then {MainCourse}, then {Dessert}");
            foreach (string topping in toppings)
            {
                Console.WriteLine($"And some {topping} on top!");
            }
        }
    }
}
