using System;

namespace DesignPatterns.Facade
{
    public abstract class Edible
    {
        public bool IsEaten;
        public void Eat()
        {
            if (IsEaten)
            {
                throw new Exception("Already eaten!");
            }

            IsEaten = true;
        }
    }
}