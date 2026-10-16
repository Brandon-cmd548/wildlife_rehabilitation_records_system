using BRAnimalRehabSystem.DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BRAnimalRehabSystem.ApplicationLogic
{
    internal class UpdateLogic
    {
        List<Animal> animals = new List<Animal>();
        AnimalFileHandler handler=new AnimalFileHandler();
        public UpdateLogic()
        {
            animals = handler.LoadAnimalList(@"C:\Users\BC-STUDENT\Downloads\BRAnimalRehabSystem\BRAnimalRehabSystem\DataLayer\animals.txt");
        }

        public Animal FillData(string id)
        {
            Animal returner = null;
            bool found = false;
            foreach (Animal animal in animals)
            {
                if (animal.AnimalID==id)
                {
                    returner=animal;
                    found = true;
                }
            }
            return returner;
        }

        public bool Update(Animal oldAnimal,Animal newAnimal)
        {
            int i=animals.IndexOf(oldAnimal);
            animals.RemoveAt(i);
            animals.Insert(i,newAnimal);
            return handler.SaveAnimalList(@"C:\Users\BC-STUDENT\Downloads\BRAnimalRehabSystem\BRAnimalRehabSystem\DataLayer\animals.txt", animals);
        }
    }
}
