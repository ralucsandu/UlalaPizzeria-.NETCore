using backendProiect.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace backendProiect.Repositories
{
    public class PricesRepository : IPricesRepository
    {
        private backendProiectContext db;

        public PricesRepository(backendProiectContext db)
        {
            this.db = db;
        }

        public IQueryable<Price> GetPricesIQueryable()
        {
            var prices = db.Prices;
            return prices;
        }

        public void CreatePrice(Price price)
        {
            db.Prices.Add(price);
            db.SaveChanges();
        }

        public void UpdatePrice(Price price)
        {
            db.Prices.Update(price);
            db.SaveChanges();
        }
        public void DeletePrice(Price price)
        {
            db.Prices.Remove(price);
            db.SaveChanges();
        }
    }
}
