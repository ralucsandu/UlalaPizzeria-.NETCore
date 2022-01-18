using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace backendProiect.Entities
{
    public class Review
    {
        public int ReviewId { get; set; }
        public string Content { get; set; }
        public int FoodId { get; set; }
        public Food Food { get; set; }
    }
}
