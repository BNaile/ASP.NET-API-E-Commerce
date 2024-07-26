using E_CommerceAPI.Application.Repositories;
using Microsoft.EntityFrameworkCore;
using E_CommerceAPI.Persistance.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using E_CommerceAPI.Domain.Entities.Common;

namespace E_CommerceAPI.Persistance.Repositories
{
    public class ReadRepository<T> : IReadRepository<T> where T : BaseEntity
    {
        private readonly E_CommerceAPIDbContext _context;
        
        public ReadRepository(E_CommerceAPIDbContext context) 
        {
            _context = context;
        }

        public DbSet<T> Table => _context.Set<T>();

        public IQueryable<T> GetAll()
        
           =>Table;

        public IQueryable<T> GetWhere(Expression<Func<T, bool>> method)
        => Table.Where(method);

        public async Task<T> GetSingleAsync(Expression<Func<T, bool>> method)
              =>await Table.FirstOrDefaultAsync(method);

        public async Task<T> GetByIdAsync(string id)
        
           => await Table.FirstOrDefaultAsync(data=>data.Id==Guid.Parse(id));
        

    }
}
