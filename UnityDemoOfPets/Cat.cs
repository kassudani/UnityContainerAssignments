using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnityDemoOfPets
{
    class Cat : IAnimalToPet
    {
        public void Food()
        {
            Console.WriteLine("I am a cat and I like To have Milk");
        }

        public void Sound()
        {
            Console.WriteLine("I make sound as Meow Meow");
        }
    }
}
