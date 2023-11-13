using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodTracker.Model
{
    internal class Food
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime? FoodDate {get; set;}

        public Meal Meal { get; set; } //navigation prop
        public int MealId { get; set; }

    }
}
