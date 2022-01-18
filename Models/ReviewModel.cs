using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace backendProiect.Models
{
    public class ReviewModel
    {
        public int ReviewId { get; set; }
        public string Content { get; set; }
        public int FoodId { get; set; }

    }
}
