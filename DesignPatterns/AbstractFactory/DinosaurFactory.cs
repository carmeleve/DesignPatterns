using DesignPatterns.Dinosaur;
using System;

namespace DesignPatterns.AbstractFactory
{
    public class DinosaurFactory : IDinosaurFactory
    {
        private readonly DinosaurType dinosaurType;

        public DinosaurFactory(string dinosaurType)
        {
            Enum.TryParse(dinosaurType, true, out this.dinosaurType);
        }

        public IDinosaur CreateADinosaur()
        {
            switch (this.dinosaurType)
            {
                case DinosaurType.TRex:
                    return new TRex();
                case DinosaurType.Stegosaurus:
                    return new Stegosaurus();
            }

            return null;
        }
    }
}
