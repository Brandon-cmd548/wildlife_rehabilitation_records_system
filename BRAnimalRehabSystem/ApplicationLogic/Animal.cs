using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BRAnimalRehabSystem.ApplicationLogic
{
    internal class Animal
    {
        public string AnimalID { get; set; }
        public string AnimalName { get; set; }
        public string AnimalSpecies { get; set; }
        public int AnimalAge { get; set; }
        public int AnimalRecoveryScore { get; set; }
        public string AnimalStatus { get; set; }
        public string AnimalHousing { get; set; }

        public Animal(string aID, string aN, string aSP, int aA, int aRS, string aST, string aH)
        {
            AnimalID = aID;
            AnimalName = aN;
            AnimalSpecies = aSP;
            AnimalAge = aA;
            AnimalRecoveryScore = aRS;
            AnimalStatus = aST;
            AnimalHousing = aH;
        }
    }
}
