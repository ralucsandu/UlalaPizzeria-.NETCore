using backendProiect.Entities;
using backendProiect.Models;
using backendProiect.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace backendProiect.Managers
{
    public class PricesManager : IPricesManager
    {
        private readonly IPricesRepository pricesRepository;
        public PricesManager(IPricesRepository pricesRepository)
        {
            this.pricesRepository = pricesRepository;
        }

        public List<int> GetPriceIdsList()
        {
            var prices = pricesRepository.GetPricesIQueryable();
            var idList = prices.Select(x => x.PriceId)
                .ToList();

            return idList;
        }

        public List<Price> GetPrices()
        {
            return pricesRepository.GetPricesIQueryable().ToList();
        }
        public void CreatePrice(PriceModel priceModel)
        {
            var newPrice = new Price
            {
                PriceId = priceModel.PriceId,
                Value = priceModel.Value
            };

            pricesRepository.CreatePrice(newPrice);
        }
        public Price GetPriceById(int id)
        {
            var price = pricesRepository.GetPricesIQueryable()
                .FirstOrDefault(x => x.PriceId == id);
            return price;
        }
        public void UpdatePrice(PriceModel priceModel)
        {
            var price = GetPriceById(priceModel.PriceId);
            price.Value = priceModel.Value;
            pricesRepository.UpdatePrice(price);
        }

        public void DeletePrice(int PriceId)
        {
            var price = GetPriceById(PriceId);
            pricesRepository.DeletePrice(price);
        }

    }
}
