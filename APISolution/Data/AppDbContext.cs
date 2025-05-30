// Data/AppDbContext.cs
using Microsoft.EntityFrameworkCore;
using APISolution.Models;
using System.Collections.Generic;

namespace APISolution.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Customer> Customers { get; set; }
        public DbSet<Case> Cases { get; set; }
    }
}
