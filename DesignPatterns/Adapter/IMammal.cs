using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Adapter
{
    public interface IMammal
    {
        IChild GiveBirth();
    }
}
