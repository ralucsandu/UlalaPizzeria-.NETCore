using backendProiect.Entities;
using backendProiect.Models;
using backendProiect.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace backendProiect.Managers
{
    public class FoodsManager : IFoodsManager
    {
        private readonly IFoodsRepository foodsRepository;
        public FoodsManager(IFoodsRepository foodsRepository)
        {
            this.foodsRepository = foodsRepository;
        }
        public List<Food>GetFoods()
        {
            return foodsRepository.GetFoodsIQueryable().ToList();
        }
        public List<int> GetFoodIdsList()
        {
            var foods = foodsRepository.GetFoodsIQueryable();
            var idList = foods.Select(x => x.FoodId)
                .ToList();

            return idList;

        }
        public List<Price> GetPricesWithFoods()
        {
            var pricesWithFoods = foodsRepository.GetPricesWithFoods();
            return pricesWithFoods.ToList();
        }

        //join-incercare
        public List<Food> GetPricesWithFoodsOrderDesc()
        {
            var foods = foodsRepository.GetPricesWithFoodsOrderDesc().ToList()
                   .OrderByDescending(x => Int32.Parse(Regex.Match(x.Price.Value, @"\d+").Value))
                   .ToList();
            return foods.ToList();
        }

        public List<Price> GetPricesFiltered()
        {
            var prices = foodsRepository.GetPricesWithFoods();
            var filtered = prices.Where(x => x.Foods.Count > 0).ToList();
            return filtered;
        }

        public List<FoodFirstNameModel> GetOrderedFoods()
        {
            var orderedFoods = foodsRepository.GetPricesWithFoods()
                .Where(x => x.Foods.Count >0)
                .Select(x => new FoodFirstNameModel { PriceId = x.PriceId, FirstFoodName = x.Foods.FirstOrDefault().Name })
                .OrderByDescending(x => x.FirstFoodName)
                .ToList();

            return orderedFoods;
        }

        public Food GetFoodById(int id)
        {
            var food = foodsRepository.GetFoodsIQueryable()
                .FirstOrDefault(x => x.FoodId == id);
            return food;
        }

        public void CreateFood(FoodModel foodModel)
        {
            var newFood = new Food
            {
                Name = foodModel.Name,
                Type = foodModel.Type,
                PriceId = foodModel.PriceId
            };

            foodsRepository.CreateFood(newFood);
        }

        public void UpdateFood(FoodModel foodModel)
        {
            var food = GetFoodById(foodModel.FoodId);
            food.Type = foodModel.Type;
            food.Name = foodModel.Name;
            foodsRepository.UpdateFood(food);
        }

        public void DeleteFood(int FoodId)
        {
            var food = GetFoodById(FoodId);
            foodsRepository.DeleteFood(food);
        }


    }
}
