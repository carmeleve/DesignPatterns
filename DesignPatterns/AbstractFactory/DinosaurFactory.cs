using DesignPatterns.Dinosaur;
using System;

namespace DesignPatterns.AbstractFactory
{
    public class DinosaurFactory : IDinosaurFactory
    {
        private readonly string dinosaurType;

        public DinosaurFactory(string dinosaurType)
        {
            this.dinosaurType = dinosaurType;
        }

        public IDinosaur CreateADinosaur()
        {
            Enum.TryParse(this.dinosaurType, true, out DinosaurType dinosaurTypeEnum);

            switch (dinosaurTypeEnum)
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
