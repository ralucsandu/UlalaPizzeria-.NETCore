using backendProiect.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace backendProiect.Repositories
{
    public interface IFoodsRepository
    {
        IQueryable<Food> GetFoodsIQueryable();
        IQueryable<Price> GetPricesWithFoods();
        IQueryable<Food> GetPricesWithFoodsOrderDesc(); //join-incercare
        void CreateFood(Food food);
        void UpdateFood(Food food);
        void DeleteFood(Food food);

    }
}
