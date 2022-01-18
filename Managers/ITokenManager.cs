using backendProiect.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace backendProiect.Managers
{
    public interface ITokenManager
    {
        Task<string> CreateToken(User user);
    }
}
