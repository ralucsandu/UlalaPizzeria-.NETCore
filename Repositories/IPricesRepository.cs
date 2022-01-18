using backendProiect.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace backendProiect.Repositories
{
    public interface IPricesRepository
    {
        IQueryable<Price> GetPricesIQueryable();
        void CreatePrice(Price price);
        void UpdatePrice(Price price);
        void DeletePrice(Price price);
    }
}
