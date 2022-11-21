using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactoryPattern
{
    public class Octopus : IAnimal
    {
        public string Sounds()
        {
            return "SQUAWCK";
        }
    }
}
