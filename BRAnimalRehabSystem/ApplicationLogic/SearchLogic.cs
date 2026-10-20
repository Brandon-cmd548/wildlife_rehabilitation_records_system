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
                List<Animal> animals = handler.LoadAnimalList(@"C:\Users\Cactu\OneDrive - belgiumcampus.ac.za\Belgium College Work\2nd Year 120 Credits\Semester 2\PRG282\Project\BRAnimalRehabSystem\DataLayer\animals.txt");
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
