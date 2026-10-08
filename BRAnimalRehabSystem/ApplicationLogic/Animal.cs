using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BRAnimalRehabSystem.ApplicationLogic
{
    internal class Animal
    {
        private string AnimalID { get; set; }
        private string AnimalName { get; set; }
        private string AnimalSpecies { get; set; }
        private int AnimalAge { get; set; }
        private int AnimalRecoveryScore { get; set; }
        private string AnimalStatus { get; set; }
        private string AnimalHousing { get; set; }

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
