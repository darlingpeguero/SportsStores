using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SportsStore.Models;

namespace SportsStore.Models
{
    public class EFStoreRepository : IStoreRepository
    {
        private StoreDbContext context;

        public EFStoreRepository(StoreDbContext ctx) 
        {
            context = ctx;
        }

        public IQueryable<Product> Products => context.Products;
    }
}
