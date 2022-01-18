using backendProiect.Entities;
using backendProiect.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace backendProiect.Managers
{
    public interface IPricesManager
    {
        List<Price> GetPrices();
        List<int> GetPriceIdsList();
        Price GetPriceById(int id);
        void CreatePrice(PriceModel priceModel);
        void UpdatePrice(PriceModel priceModel);
        void DeletePrice(int PriceId);
    }
}
