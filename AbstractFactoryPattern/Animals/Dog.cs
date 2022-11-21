using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactoryPattern
{
    public class Dog : IAnimal
    {
        public string Sounds()
        {
            return "Barks";
        }
    }
}
