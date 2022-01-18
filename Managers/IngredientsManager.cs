using backendProiect.Entities;
using backendProiect.Models;
using backendProiect.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace backendProiect.Managers
{
    public class IngredientsManager : IIngredientsManager
    {
        private readonly IIngredientsRepository ingredientsRepository;
        public IngredientsManager(IIngredientsRepository ingredientsRepository)
        {
            this.ingredientsRepository = ingredientsRepository;
        }
        public List<Ingredient> GetIngredients()
        {
            return ingredientsRepository.GetIngredientsIQueryable().ToList();
        }
        public List<int> GetIngredientIdsList()
        {
            var ingredients = ingredientsRepository.GetIngredientsIQueryable();
            var idList = ingredients.Select(x => x.IngredientId)
                .ToList();

            return idList;
        }
        public void CreateIngredient(IngredientModel ingredientModel)
        {
            var newIngredient = new Ingredient
            {
                IngredientId = ingredientModel.IngredientId,
                Name = ingredientModel.Name
            };

            ingredientsRepository.CreateIngredient(newIngredient);
        }
        public void UpdateIngredient(IngredientModel ingredientModel)
        {
            var ingredient = GetIngredientById(ingredientModel.IngredientId);
            ingredient.Name = ingredientModel.Name;
            ingredientsRepository.UpdateIngredient(ingredient);
        }

        public void DeleteIngredient(int IngredientId)
        {
            var ingredient = GetIngredientById(IngredientId);
            ingredientsRepository.DeleteIngredient(ingredient);
        }

        public Ingredient GetIngredientById(int id)
        {
            var ingredient = ingredientsRepository.GetIngredientsIQueryable()
                .FirstOrDefault(x => x.IngredientId == id);
            return ingredient;
        }
    }
}
