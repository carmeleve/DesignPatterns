using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Facade
{
    public class DinoEcosystemFacade
    {
        private readonly Soil soil;

        public DinoEcosystemFacade(Soil soil)
        {
            this.soil = soil;
        }

        public void RunAGeneration()
        {
            var plant = new Plant(this.soil);
            var herbivore = new Herbivore(plant);
            var carnivore = new Carnivore(herbivore);
            carnivore.Die(this.soil);
        }
    }
}
