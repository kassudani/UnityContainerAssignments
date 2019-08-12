using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnityDemoOfPets
{
    class Dog : IAnimalToPet
    {
        public void Food()
        {
            Console.WriteLine("I am a Dog and I like Bones");
        }

        public void Sound()
        {
            Console.WriteLine("I Bark - Bhaw Bhaw");
        }
    }
}
