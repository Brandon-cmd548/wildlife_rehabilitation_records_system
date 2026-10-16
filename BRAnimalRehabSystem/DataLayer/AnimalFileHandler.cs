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

                    if (int.TryParse(lineSpliter[3], out int animalAge))
                    {
                        
                    }
                    else
                    {
                        MessageBox.Show($"Text doc has bad data, pls go fix line: {line}, {lineSpliter[3]}");
                        continue;
                    }

                    if (int.TryParse(lineSpliter[4], out int animalRecoveryScore))
                    {

                    }
                    else
                    {
                        MessageBox.Show($"Text doc has bad data, pls go fix line: {line}, {lineSpliter[4]}");
                        continue;
                    }

                    // 2. I 604838 was taught the code below by an AI 
                    Animal animal = new Animal(lineSpliter[0], lineSpliter[1], lineSpliter[2], animalAge, animalRecoveryScore, lineSpliter[5], lineSpliter[6]);
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

        public void SaveAnimalList(string animalsTxtPath, List<Animal> animalList)
        {
            try
            {
                List<string> lines = new List<string>();
                bool range = false;
                foreach (Animal animal in animalList)
                {
                    int score = animal.AnimalRecoveryScore;
                    if (score >= 0 && score <= 100)
                    {
                        if (score <= 20)
                        {
                            animal.AnimalHousing = "Intensive Care Unit";
                            animal.AnimalStatus = "Critical";
                        }
                        else
                        {
                            if (score <= 40)
                            {
                                animal.AnimalHousing = "High-Dependency Ward";
                                animal.AnimalStatus = "Serious";
                            }
                            else
                            {
                                if (score <= 60)
                                {
                                    animal.AnimalHousing = "Recovery Ward";
                                    animal.AnimalStatus = "Stable";
                                }
                                else
                                {
                                    if (score <= 80)
                                    {
                                        animal.AnimalHousing = "Outdoor Enclosure";
                                        animal.AnimalStatus = "Recovering";
                                    }
                                    else
                                    {
                                        animal.AnimalHousing = "Pre-Release Camp";
                                        animal.AnimalStatus = "Release-Ready";
                                    }
                                }
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Recovery score outside the 0-100 range");
                        range = true;
                    }
                    lines.Add($"{animal.AnimalID}|{animal.AnimalName}|{animal.AnimalSpecies}|{animal.AnimalAge}|{animal.AnimalRecoveryScore}|{animal.AnimalStatus}|{animal.AnimalHousing}");
                }
                if (!range)
                {
                    File.WriteAllLines(animalsTxtPath, lines);
                }
                else
                {
                    MessageBox.Show("Changes not saved due to error");
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show("Error happened at SavenimalList Method:\n" + exc.Message);
            }
        }
    }
}
