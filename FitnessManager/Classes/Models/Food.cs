using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitnessManager.Classes.Models
{
    public class Food
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Calories { get; set; }
        public double Carbs { get; set; }
        public double Fats { get; set; }
        public double Proteins { get; set; }

        private Food(int id, string name, int calories, double carbs, double fats, double proteins)
        {
            Id = id;
            Name = name;
            Calories = calories;
            Carbs = carbs;
            Fats = fats;
            Proteins = proteins;
        }

        private Food() { }

        public override string ToString()
        {
            return Name;
        }
    }
}
