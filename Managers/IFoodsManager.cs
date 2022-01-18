using backendProiect.Entities;
using backendProiect.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace backendProiect.Managers
{
    public interface IFoodsManager
    {
        List<Food> GetFoods();
        List<int> GetFoodIdsList();
        List<Price> GetPricesWithFoods();
        List<Price> GetPricesFiltered();
        List<FoodFirstNameModel> GetOrderedFoods();
        List<Food> GetPricesWithFoodsOrderDesc();    //join-incercare
        Food GetFoodById(int id);
        void CreateFood(FoodModel foodModel);
        void UpdateFood(FoodModel foodModel);
        void DeleteFood(int FoodId);

    }
}
