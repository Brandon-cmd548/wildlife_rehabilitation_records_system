using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BRAnimalRehabSystem.DataLayer;

namespace BRAnimalRehabSystem.ApplicationLogic
{
    internal class SearchLogic
    {

        public Animal Search(string id) 
        {
            AnimalFileHandler handler = new AnimalFileHandler();
            Animal found = null;
            try
            {
                List<Animal> animals = handler.LoadAnimalList(@"C:\Users\BC-STUDENT\Downloads\BRAnimalRehabSystem\BRAnimalRehabSystem\DataLayer\animals.txt");
                foreach (Animal animal in animals)
                {
                    if (animal.AnimalID == id)
                    {
                        found = animal;
                    }
                }
                if (found == null)
                {
                    MessageBox.Show("ID not found");
                }
                return found;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Search Error: " + ex.Message);
                return found;
            }
        }
    }
}
