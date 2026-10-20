using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BRAnimalRehabSystem.ApplicationLogic
{
    internal class AnimalClassification
    {
        public static (string Status, string Housing)
            ClassifyAnimal(int score)
            {
              if (score < 0 || score > 100)
              {
                throw new ArgumentOutOfRangeException(nameof(score));
              }
              if (score <= 19)
              {
                return ("Critical", "Intensive Care Unit");
              }
              else if (score <= 39)
              {
                return ("Serious", "High-Dependency Ward");
              }
              else if (score <= 59)
              {
                return ("Stable", "Recovery Ward");
              }
              else if (score <= 79)
              {
                return ("Recovering", "Outdoor Enclosure");
              }
              else
              { 
                return ("Release-Ready", "Pre-Release Camp");
              }


            }
        

    }
}
