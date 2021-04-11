using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VerduleriaApp.Data.Context;
using VerduleriaApp.Data.Requests;
using VerduleriaApp.Data.Responses;
using VerduleriaApp.Services;

namespace VerduleriaApp.Controllers
{
    [Route("api/sale")]
    [ApiController]
    public class SalesController : ControllerBase
    {
        private readonly ISaleService _salesService;

        public SalesController(DBcontext context, ISaleService salesService)
        {
            _salesService = salesService;
        }

        [HttpPost]
        public IActionResult Add(SaleRequest req)
        {
            var resp = new ProductsResponse();

            try
            {
                _salesService.Add(req);
                resp.Success = 1;
            }
            catch(Exception ex)
            {
                resp.Message = ex.Message;
                return BadRequest(resp);
            }

            return Ok(resp);
        }
    }
}
