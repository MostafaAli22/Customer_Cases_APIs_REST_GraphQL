using APISolution.Data;
using APISolution.Models;

namespace APISolution.GraphQL
{
    public class Mutation
    {
        //[UseDbContext(typeof(AppDbContext))]
        public async Task<Customer> UpdateCustomerEmailAsync(
            int customerID,
            string email,
            [Service] AppDbContext context)
        {
            var customer = await context.Customers.FindAsync(customerID);
            if (customer == null)
            {
                throw new GraphQLException($"Customer with ID {customerID} not found.");
            }

            customer.Email = email;
            await context.SaveChangesAsync();

            return customer;
        }
    }

}
