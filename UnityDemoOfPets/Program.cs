using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unity;

namespace UnityDemoOfPets
{
    class Program
    {
        static void Main(string[] args)
        {
            //Owner petOwner = new Owner(new Cat());
            //Owner petOwner = new Owner(new Cow());
            //Owner petOwner = new Owner(new Dog());
            //petOwner.ActionsOfMyPet();
            //Console.WriteLine("-----------------------------");

            IUnityContainer container = new UnityContainer();
            container.RegisterType<IAnimalToPet, Dog>();
            Owner petOwner = container.Resolve<Owner>();
            petOwner.ActionsOfMyPet();
            Console.ReadKey();
        }
    }
}
