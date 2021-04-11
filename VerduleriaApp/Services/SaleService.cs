using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VerduleriaApp.Data.Context;
using VerduleriaApp.Data.Models;
using VerduleriaApp.Data.Requests;

namespace VerduleriaApp.Services
{
    public class SaleService : ISaleService
    {
        private readonly DBcontext _context;

        public SaleService(DBcontext context)
        {
           _context = context;
        }

        public void Add(SaleRequest req)
        {
            using var transaction = _context.Database.BeginTransaction();

            try
            {
                var sale = new Sale();
                sale.Total = req.Total;
                sale.Date = DateTime.Now;
                _context.Sale.Add(sale);
                _context.SaveChanges();

                foreach(var reqConcept in req.Concepts)
                {
                    Concept concept = new Concept
                    {
                        IdSale = sale.Id,
                        IdProduct = reqConcept.IdProduct,
                        Amount = reqConcept.Amount,
                    };

                    _context.Concept.Add(concept);
                    _context.SaveChanges();
                }

                transaction.Commit();
            }
            catch(Exception ex)
            {
                transaction.Rollback();
                throw new Exception("Error on the transaction");
            }
        }
    }
}
