using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactoryPattern
{
    public class Cat : IAnimal
    {
        public string Sounds()
        {
            return "Meow Meow Meow";
        }
    }
}
