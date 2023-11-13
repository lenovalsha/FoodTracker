using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodTracker.Model
{
    internal class Meal
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public override string ToString() //everyime the ToString is being called we will just return the name
        {
            return Name;
        }
    }
}
