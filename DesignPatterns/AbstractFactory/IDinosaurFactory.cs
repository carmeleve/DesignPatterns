using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.AbstractFactory
{
    public interface IDinosaurFactory
    {
        IDinosaur CreateADinosaur();
    }
}
