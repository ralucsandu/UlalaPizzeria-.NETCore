using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace backendProiect.Entities
{
    public class Image
    {
        public int ImageId { get; set; }
        public string URL { get; set; }
        public int FoodId { get; set; }
        public Food Food { get; set; }
    }
}
