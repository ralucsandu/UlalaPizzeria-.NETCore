using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using backendProiect.Entities;
using backendProiect.Managers;
using backendProiect.Models;

namespace backendProiect.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PriceController : ControllerBase
    {
        private readonly IPricesManager manager;
        public PriceController(IPricesManager pricesManager)
        {
            this.manager = pricesManager;
        }

        [HttpGet]
        public async Task<IActionResult> GetPrices()
        {
            var prices = manager.GetPrices();
            return Ok(prices);
        }

        [HttpGet("select-price-id")]
        public async Task<IActionResult> GetPriceIds()
        {
            var idList = manager.GetPriceIdsList();
            return Ok(idList);
        }

        [HttpPost]
        public async Task<IActionResult> CreatePrice([FromBody] PriceModel priceModel)
        {
            manager.CreatePrice(priceModel);

            return Ok();
        }

        [HttpPut]
        public async Task<IActionResult> UpdatePrice([FromBody] PriceModel priceModel)
        {
            manager.UpdatePrice(priceModel);
            return Ok();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeletePrice([FromRoute] int id)
        {
            manager.DeletePrice(id);
            return Ok();
        }
    }
}
