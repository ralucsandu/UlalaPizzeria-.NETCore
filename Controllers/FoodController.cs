using backendProiect.Entities;
using backendProiect.Managers;
using backendProiect.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace backendProiect.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FoodController : ControllerBase
    {
        private readonly IFoodsManager manager;
        public FoodController(IFoodsManager foodsManager)
        {
            this.manager = foodsManager;
        }

        [HttpGet]
        public async Task<IActionResult>GetFoods()
        {
            var foods = manager.GetFoods();
            return Ok(foods);
        }

        [HttpGet("select-id")] //select FoodId from Foods
        public async Task<IActionResult> GetFoodIds()
        {
            var idList = manager.GetFoodIdsList();
            return Ok(idList);
        }

        [HttpGet("join-Prices-Foods")] //join between Foods and Prices
        public async Task<IActionResult>JoinPricesFoods()
        {
            var pricesWithFoods = manager.GetPricesWithFoods();

            return Ok(pricesWithFoods);
        }

      [HttpGet("filter")]
        public async Task<IActionResult> Filtered()
        {
            var pricesFiltered = manager.GetPricesFiltered();

            return Ok(pricesFiltered);
        }

        [HttpGet("order-by-desc")]
        public async Task<IActionResult> OrderByFoodNameDesc()
        {
            var orderedFoods = manager.GetOrderedFoods();

            return Ok(orderedFoods);
        }

        [HttpGet("join-incercare")]
        public async Task<IActionResult> JoinPricesFoodsOrderDesc()
        {
            var pricesWithFoodsOrderDesc = manager.GetPricesWithFoodsOrderDesc();
            return Ok(pricesWithFoodsOrderDesc);
        }

        [HttpGet("byId/{id}")]
        public async Task<IActionResult> GetById([FromRoute] int id)
        {
            var food = manager.GetFoodById(id);
            return Ok(food);
        }
        
        [HttpPost]
        public async Task<IActionResult> CreateFood([FromBody] FoodModel foodModel)
        {
            manager.CreateFood(foodModel);

            return Ok();
        }

        [HttpPut]
        public async Task<IActionResult>UpdateFood([FromBody] FoodModel foodModel)
        {
            manager.UpdateFood(foodModel);
            return Ok();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult>DeleteFood([FromRoute] int id)
        {
            manager.DeleteFood(id);
            return Ok();
        }


    }

}
