using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnityDemoOfPets
{
    class Owner
    {
        IAnimalToPet MyPet = null;
        public Owner (IAnimalToPet myPet)
        {
            MyPet = myPet;
        }
        public void ActionsOfMyPet()
        {
            MyPet.Food();
            MyPet.Sound();
        }
    }
}
