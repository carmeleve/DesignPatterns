using System.Collections.Generic;
using System.Linq;

namespace DesignPatterns.Dinosaur
{
    public class Dessert
    {
        public string Name { get; set; }
        private readonly IList<string> toppings = new List<string>();

        public Dessert(string dessertName)
        {
            Name = dessertName;
        }

        public void AddTopping(string topping)
        {
            toppings.Add(topping);
        }

        public string ListToppings()
        {
            return ProduceToppingString(this.toppings);
        }

        private static string ProduceToppingString(IList<string> toppings)
        {
            if (toppings.Count == 1)
            {
                return toppings.First();
            }

            string toppingList = string.Empty;

            for (int i = 0; i < toppings.Count - 1; i++)
            {
                toppingList += $"{toppings[i]}, ";
            }

            toppingList += $"and {toppings.Last()}";

            return toppingList;
        }
    }
}