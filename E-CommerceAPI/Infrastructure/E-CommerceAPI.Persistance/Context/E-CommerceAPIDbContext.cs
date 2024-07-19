using E_CommerceAPI.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_CommerceAPI.Persistance.Context
{
    public class E_CommerceAPIDbContext : DbContext
    {
        public E_CommerceAPIDbContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<Product>Products { get; set; }
        public DbSet<Order>Orders { get; set; }
        public DbSet<Customer>Customers { get; set; }
    }
}
