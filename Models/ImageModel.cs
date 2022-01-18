using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace backendProiect.Models
{
    public class ImageModel
    {
        public int ImageId { get; set; }
        public string URL { get; set; }
        public int FoodId { get; set; }
    }
}
