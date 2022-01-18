using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace backendProiect.Entities
{
    public class FoodIngredients
    {
        public int FoodId { get; set; }
        public int IngredientId { get; set; }

        public Food Food { get; set; }
        public Ingredient Ingredient { get; set; }
    }
}
