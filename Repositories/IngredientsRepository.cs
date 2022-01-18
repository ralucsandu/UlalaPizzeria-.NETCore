using backendProiect.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace backendProiect.Repositories
{
    public class IngredientsRepository : IIngredientsRepository
    {
        private backendProiectContext db;
        public IngredientsRepository(backendProiectContext db)
        {
            this.db = db;
        }

        public void CreateIngredient(Ingredient ingredient)
        {
            db.Ingredients.Add(ingredient);
            db.SaveChanges();
        }

        public void DeleteIngredient(Ingredient ingredient)
        {
            db.Ingredients.Remove(ingredient);
            db.SaveChanges();
        }

        public IQueryable<Ingredient> GetIngredientsIQueryable()
        {
            var ingredients = db.Ingredients;
            return ingredients;
        }

        public void UpdateIngredient(Ingredient ingredient)
        {
            db.Ingredients.Update(ingredient);
            db.SaveChanges();
        }
    }
}
