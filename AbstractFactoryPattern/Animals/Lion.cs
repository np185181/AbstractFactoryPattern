using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactoryPattern
{
    public class Lion : IAnimal
    {
        public string Sounds()
        {
            return "Roars";
        }
    }
}
