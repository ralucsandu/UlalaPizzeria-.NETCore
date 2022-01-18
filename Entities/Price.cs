using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace backendProiect.Entities
{
    public class Price
    {
        public int PriceId { get; set; }
        public string Value { get; set; }
        public ICollection<Food> Foods { get; set; }
    }
}
