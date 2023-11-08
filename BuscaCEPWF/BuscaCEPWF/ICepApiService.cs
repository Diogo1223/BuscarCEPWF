using Refit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuscaCEPWF
{
    interface ICepApiService
    {
        [Get("/ws/{cep}/json")]

        Task<CepResponde> GetAddressAsync(string cep);
    }
}
