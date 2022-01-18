using backendProiect.Entities;
using backendProiect.Managers;
using backendProiect.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace backendProiect.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class IngredientController : ControllerBase
    {
        private readonly IIngredientsManager manager;
        public IngredientController(IIngredientsManager ingredientsManager)
        {
            this.manager = ingredientsManager;
        }
        [HttpGet]
        public async Task<IActionResult> GetIngredients()
        {
            var ingredients = manager.GetIngredients();
            return Ok(ingredients);
        }
        [HttpGet("select-ingredient-id")]
        public async Task<IActionResult> GetIngredientIds()
        {
            var idList = manager.GetIngredientIdsList();
            return Ok(idList);
        }

        [HttpPost]
        public async Task<IActionResult> CreateIngredient([FromBody] IngredientModel ingredientModel)
        {
            manager.CreateIngredient(ingredientModel);

            return Ok();
        }

        [HttpPut]
        public async Task<IActionResult> UpdateIngredient([FromBody] IngredientModel ingredientModel)
        {
            manager.UpdateIngredient(ingredientModel);
            return Ok();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteIngredient([FromRoute] int id)
        {
            manager.DeleteIngredient(id);
            return Ok();
        }
    }
}
