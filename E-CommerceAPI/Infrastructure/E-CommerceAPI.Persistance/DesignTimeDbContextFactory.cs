using E_CommerceAPI.Persistance.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_CommerceAPI.Persistance
{
    public class DesignTimeDbContextFactory : IDesignTimeDbContextFactory<E_CommerceAPIDbContext>
    {
        public E_CommerceAPIDbContext CreateDbContext(string[] args)
        {
           

            DbContextOptionsBuilder<E_CommerceAPIDbContext> dbContextOptionsBuilder = new();
            dbContextOptionsBuilder.UseNpgsql (Configuration.ConnectionString);
            return new(dbContextOptionsBuilder.Options);
        }
    }
}
