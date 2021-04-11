using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VerduleriaApp.Data.Responses
{
    public class ProductsResponse
    {
        public int Success { get; set; }
        public string Message { get; set; }
        public object Data { get; set; }

        public ProductsResponse()
        {
            this.Success = 0;  
        }
    }
}
