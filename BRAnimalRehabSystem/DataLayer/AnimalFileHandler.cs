using BRAnimalRehabSystem.ApplicationLogic;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BRAnimalRehabSystem.DataLayer
{
    internal class AnimalFileHandler
    {
        public List<Animal> LoadAnimalList(string animalsTxtPath)
        {
            try
            {
                FileStream fsLoadAnimal = new FileStream(animalsTxtPath, FileMode.OpenOrCreate);
                StreamReader srLoadAnimal = new StreamReader(fsLoadAnimal);

                string line;

                List<Animal> animalList = new List<Animal>();
                while ((line = srLoadAnimal.ReadLine()) != null)
                {
                    line = line.Trim();

                    // 1. I 604838 was taught the code below by an AI 
                    string[] lineSpliter = line.Split('|');
                    // 1. I 604838 was taught the code above by an AI 

                    if (lineSpliter.Length != 7)
                    {
                        MessageBox.Show($"Text doc has bad data, pls go fix line: {line}");
                        continue;
                    }

                    // 2. I 604838 was taught the code below by an AI 
                    Animal animal = new Animal(lineSpliter[0], lineSpliter[1], lineSpliter[2], int.Parse(lineSpliter[3]), int.Parse(lineSpliter[4]), lineSpliter[5], lineSpliter[6]);
                    // 2. I 604838 was taught the code above by an AI 

                    animalList.Add(animal);
                }
                srLoadAnimal.Close();
                fsLoadAnimal.Close();

                return animalList;
            }
            catch (Exception exc)
            {
                MessageBox.Show("Error happened at LoadAnimalList Method:\n" + exc.Message);
                return null;
            }
        }
    }
}
