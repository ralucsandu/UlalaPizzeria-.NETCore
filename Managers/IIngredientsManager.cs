using backendProiect.Entities;
using backendProiect.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace backendProiect.Managers
{
    public interface IIngredientsManager
    {
        List<Ingredient> GetIngredients();
        List<int> GetIngredientIdsList();
        Ingredient GetIngredientById(int id);
        void CreateIngredient(IngredientModel ingredientModel);
        void UpdateIngredient(IngredientModel ingredientModel);
        void DeleteIngredient(int IngredientId);
    }
}
