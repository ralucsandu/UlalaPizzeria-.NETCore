using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace backendProiect.Entities
{
    public class Food
    {
        public int FoodId { get; set; }
        public string Type { get; set; }
        public string Name { get; set; }
        public Image Image { get; set; }
        public int PriceId { get; set; }
        public Price Price { get; set; }
        public ICollection<Review> Reviews { get; set; }
        public ICollection<FoodIngredients> FoodsIngredients { get; set; }

    }
}
