using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace FarmManagementApp
{
    public partial class Form1 : Form
    {
        private JsonStorageService _jsonService;
        private List<Animal> _animals;

        public Form1()
        {
            InitializeComponent();
            _jsonService = new JsonStorageService();
            UpdateAnimalStats();  // Load initial data
        }

        private void AddAnimal(Animal animal)
        {
            if (animal.Quantity <= 0)
                return; // Ignore adding if quantity is 0 or negative

            var existingAnimal = _animals.FirstOrDefault(a => a.Type == animal.Type);
            if (existingAnimal != null)
            {
                existingAnimal.Quantity += animal.Quantity;
            }
            else
            {
                _animals.Add(animal);
            }
            _jsonService.SaveAnimals(_animals);
            MessageBox.Show($"{animal.Type} added successfully.");
            UpdateAnimalStats();  // Refresh data after adding
        }

        private void RemoveAnimal(Animal animal)
        {
            if (animal.Quantity <= 0)
                return; // Ignore removing if quantity is 0 or negative

            var existingAnimal = _animals.FirstOrDefault(a => a.Type == animal.Type);
            if (existingAnimal != null && existingAnimal.Quantity >= animal.Quantity)
            {
                existingAnimal.Quantity -= animal.Quantity;
                if (existingAnimal.Quantity == 0)
                {
                    _animals.Remove(existingAnimal);  // Remove from list if quantity is 0
                }
                _jsonService.SaveAnimals(_animals);
                MessageBox.Show($"{animal.Type} removed successfully.");
            }
            else
            {
                MessageBox.Show($"{animal.Type} not found or insufficient quantity.");
            }
            UpdateAnimalStats();  // Refresh data after removing
        }

        private void ClearAnimals()
        {
            _animals.Clear();
            _jsonService.SaveAnimals(_animals);
            MessageBox.Show("All animals removed successfully.");
            UpdateAnimalStats();  // Refresh data after clearing
        }

        private void UpdateAnimalStats()
        {
            _animals = _jsonService.LoadAnimals();

            // Update labels with the latest quantities of each animal
            totalCows.Text = _animals.FirstOrDefault(a => a.Type == "Cow")?.Quantity.ToString() ?? "0";
            totalSheeps.Text = _animals.FirstOrDefault(a => a.Type == "Sheep")?.Quantity.ToString() ?? "0";
            totalGoats.Text = _animals.FirstOrDefault(a => a.Type == "Goat")?.Quantity.ToString() ?? "0";

            // Calculate total milk and update the milk labels
            int totalCowMilk = _animals.Where(a => a.Type == "Cow").Sum(a => a.ProduceMilk() * a.Quantity);
            int totalSheepMilk = _animals.Where(a => a.Type == "Sheep").Sum(a => a.ProduceMilk() * a.Quantity);
            int totalGoatMilk = _animals.Where(a => a.Type == "Goat").Sum(a => a.ProduceMilk() * a.Quantity);

            this.totalCowMilk.Text = totalCowMilk.ToString();
            this.totalSheepMilk.Text = totalSheepMilk.ToString();
            this.totalGoatMilk.Text = totalGoatMilk.ToString();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            if (int.TryParse(cowTextBox.Text, out int cowNumber) && cowNumber > 0)
            {
                AddAnimal(new Cow { Quantity = cowNumber });
            }
            if (int.TryParse(sheepTextBox.Text, out int sheepNumber) && sheepNumber > 0)
            {
                AddAnimal(new Sheep { Quantity = sheepNumber });
            }
            if (int.TryParse(goatTextBox.Text, out int goatNumber) && goatNumber > 0)
            {
                AddAnimal(new Goat { Quantity = goatNumber });
            }

            // Clear inputs after adding
            cowTextBox.Clear();
            sheepTextBox.Clear();
            goatTextBox.Clear();
        }

        private void removeButton_Click(object sender, EventArgs e)
        {
            if (int.TryParse(cowTextBox.Text, out int cowNumber) && cowNumber > 0)
            {
                RemoveAnimal(new Cow { Quantity = cowNumber });
            }
            if (int.TryParse(sheepTextBox.Text, out int sheepNumber) && sheepNumber > 0)
            {
                RemoveAnimal(new Sheep { Quantity = sheepNumber });
            }
            if (int.TryParse(goatTextBox.Text, out int goatNumber) && goatNumber > 0)
            {
                RemoveAnimal(new Goat { Quantity = goatNumber });
            }

            // Clear inputs after removing
            cowTextBox.Clear();
            sheepTextBox.Clear();
            goatTextBox.Clear();
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            UpdateAnimalStats();  // Refresh stats
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            ClearAnimals();
        }

        private void hearFarmSoundButton_Click(object sender, EventArgs e)
        {
            // Create a StringBuilder to collect all sounds
            var sounds = new System.Text.StringBuilder();

            // Check each animal type and append their sounds
            var cows = _animals.Where(a => a.Type == "Cow");
            var sheeps = _animals.Where(a => a.Type == "Sheep");
            var goats = _animals.Where(a => a.Type == "Goat");

            if (cows.Any())
            {
                foreach (var cow in cows)
                {
                    sounds.AppendLine(cow.MakeSound());
                }
            }
            else
            {
                sounds.AppendLine("No cows found.");
            }

            if (sheeps.Any())
            {
                foreach (var sheep in sheeps)
                {
                    sounds.AppendLine(sheep.MakeSound());
                }
            }
            else
            {
                sounds.AppendLine("No sheeps found.");
            }

            if (goats.Any())
            {
                foreach (var goat in goats)
                {
                    sounds.AppendLine(goat.MakeSound());
                }
            }
            else
            {
                sounds.AppendLine("No goats found.");
            }

            // Show all collected sounds in a message box
            MessageBox.Show(sounds.ToString());
        }


    }
}
