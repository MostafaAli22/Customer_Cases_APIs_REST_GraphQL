using APISolution.Data;
using APISolution.Models;
using HotChocolate.Data;
using Microsoft.EntityFrameworkCore;
namespace APISolution.GraphQL
{
    public class Query
    {
        //[UseDbContext(typeof(AppDbContext))] // Enables EF support
        [UseProjection]
        //[UsePaging(IncludeTotalCount = true)]
        [UseFiltering]
        [UseSorting]
        public IQueryable<Customer> GetCustomers([Service] AppDbContext dbContext, int? id = null)
        {
            if (id.HasValue)
            {
                return dbContext.Customers.Where(c => c.CustomerID == id.Value);
            }
            return dbContext.Customers;
        }


        

        //[UseDbContext(typeof(AppDbContext))]
        [UseProjection]
        [UseFiltering]
        [UseSorting]
        public IQueryable<Case> GetCases([Service] AppDbContext dbContext, int? id = null)
        {
            if (id.HasValue)
            {
                return dbContext.Cases.Where(c => c.CaseID == id.Value);
            }
            return dbContext.Cases;
        }
           
        

    }
}
