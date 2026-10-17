using BRAnimalRehabSystem.ApplicationLogic;
using BRAnimalRehabSystem.DataLayer;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BRAnimalRehabSystem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private bool ValidateAnimalInput()
        {
            string id = txtAnimalID.Text.Trim().ToUpper();

            if (!System.Text.RegularExpressions.Regex.IsMatch(id, @"^WR-[0-9]{4}$"))
            {
                MessageBox.Show("Animal must be WR- followed by exactly 4 digits.");
                txtAnimalID.Focus();
                return false;
            }

            string name = txtName.Text.Trim();
            if (name.Length < 1 || name.Length > 30 || name.Contains('|'))
            {
                MessageBox.Show("Name must be 1 to 30 characters and cannot contain |.");
                txtName.Focus();
                return false;
            }

            string species = txtSpecies.Text.Trim();

            if (species.Length < 1 || species.Length > 30 || species.Contains('|'))
            {
               MessageBox.Show("Species must be 1 to 30 characters and cannot contain |.");
                txtSpecies.Focus();
                return false;
            }

            string ageText = txtAge.Text.Trim();

            if (!System.Text.RegularExpressions.Regex.IsMatch(ageText, @"^[0-9]+$") || 
            !int.TryParse(ageText, out int age) ||
            age > 100)
            {
                MessageBox.Show("Age must be a whole number between 0 and 100 ");
                txtAge.Focus();
                return false;
            }

            string scoreText = txtRecoveryScore.Text.Trim();

            if (!System.Text.RegularExpressions.Regex.IsMatch(scoreText, @"^[0-9]+$") ||
            !int.TryParse(scoreText, out int score) ||
            score > 100)
            {
                MessageBox.Show("Recovery Score must be a whole number between 0 and 100 ");
            }
           return true;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        { 
          if (!ValidateAnimalInput())
          {
                return;
          }

            string id = txtAnimalID.Text.Trim().ToUpperInvariant();
            string name = txtName.Text.Trim();
            string species = txtSpecies.Text.Trim();
            int age = int.Parse(txtAge.Text.Trim());
            int score = int.Parse(txtRecoveryScore.Text.Trim());

            string filePath = Path.Combine(AppContext.BaseDirectory, "animals.txt");

            try
            {
                AnimalFileHandler handler = new AnimalFileHandler();

                List<Animal> animals = handler.LoadAnimalList(filePath);

                if (animals == null)
                {
                    MessageBox.Show("Unable to load animal records.");
                    return;
                }

                bool duplicate = animals.Any(a => a.AnimalID.Equals(id, StringComparison.OrdinalIgnoreCase));

                if (duplicate)
                {
                    MessageBox.Show("This animal ID already exists.");
                    txtAnimalID.Focus();
                    return;
                }

                var result = AnimalClassification.ClassifyAnimal(score);

                Animal newAnimal = new Animal(id, name, species, age, score, result.Status, result.Housing);

                string record = string.Join("|", newAnimal.AnimalID, newAnimal.AnimalName, newAnimal.AnimalSpecies, newAnimal.AnimalAge, newAnimal.AnimalRecoveryScore, newAnimal.AnimalStatus, newAnimal.AnimalHousing);

                if (File.Exists(filePath) && new FileInfo(filePath).Length > 0)
                {
                    byte[] bytes = File.ReadAllBytes(filePath);
                    byte lastByte = bytes[bytes.Length - 1];

                    if (lastByte != 10 && lastByte != 13)
                    {
                        File.AppendAllText(filePath, Environment.NewLine, new UTF8Encoding(false));
                    }
                }
                File.AppendAllText(filePath, record + Environment.NewLine, new UTF8Encoding(false));

                MessageBox.Show("Animal added successfully!\n\n" + "Status: " + result.Status + "\n" + "Housing Unit: " + result.Housing);

            }
            catch (UnauthorizedAccessException)
            {
                MessageBox.Show("Permission denied when saving animals.txt.");
            }
            catch (IOException)
            {
                MessageBox.Show("Unable to access animals.txt.");
            }  
            catch(Exception ex)
            {
                MessageBox.Show("Unable to add animal: " + ex.Message);
            }
        }
    }
}
