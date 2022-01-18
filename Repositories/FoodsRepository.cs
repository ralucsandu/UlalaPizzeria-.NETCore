using backendProiect.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace backendProiect.Repositories
{
    public class FoodsRepository : IFoodsRepository
    {
        private backendProiectContext db;

        public FoodsRepository(backendProiectContext db)
        {
            this.db = db;
        }

        public IQueryable<Food> GetFoodsIQueryable()
        {
            var foods = db.Foods;
            return foods; 
        }

        public IQueryable<Price> GetPricesWithFoods()
        {
            var prices = db.Prices.Include(x => x.Foods);
            return prices;
        }

        public IQueryable<Food> GetPricesWithFoodsOrderDesc()
        {
            var foods = db.Foods.Include(x => x.Price);
            return foods;
        }


        public void CreateFood(Food food)
        {
            db.Foods.Add(food);
            db.SaveChanges();
        }
        
        public void UpdateFood(Food food)
        {
            db.Foods.Update(food);
            db.SaveChanges();
        }

        public void DeleteFood(Food food)
        {
            db.Foods.Remove(food);
            db.SaveChanges();
        }


    }
}
