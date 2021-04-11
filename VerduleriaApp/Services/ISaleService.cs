using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VerduleriaApp.Data.Requests;

namespace VerduleriaApp.Services
{
    public interface ISaleService
    {
        public void Add(SaleRequest req);
    }
}
