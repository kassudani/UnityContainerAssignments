using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnityDemoOfPets
{
    class Cow : IAnimalToPet
    {
        public void Food()
        {
            Console.WriteLine("I am a Cow and I eat Grass");
        }

        public void Sound()
        {
            Console.WriteLine("I make Moo sound");
        }
    }
}
