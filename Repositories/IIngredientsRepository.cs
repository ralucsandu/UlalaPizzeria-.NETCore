using backendProiect.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace backendProiect.Repositories
{
    public interface IIngredientsRepository
    {
        IQueryable<Ingredient> GetIngredientsIQueryable();
        void CreateIngredient(Ingredient ingredient);
        void UpdateIngredient(Ingredient ingredient);
        void DeleteIngredient(Ingredient ingredient);
    }
}
