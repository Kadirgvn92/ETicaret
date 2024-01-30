using ETicaret.Application.Repositories;
using ETicaret.Domain.Entities.Common;
using ETicaret.Persistance.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ETicaret.Persistance.Repositories;
public class ReadRepository<T> : IReadRepository<T> where T : BaseEntity
{
    private readonly ETicaretDbContext _context;

    public ReadRepository(ETicaretDbContext context)
    {
        _context = context;
    }

    public DbSet<T> Table 
        => _context.Set<T>();

    public IQueryable<T> GetAll() 
        => Table;

    public Task<T> GetByIDAsync(string id)
        => Table.FirstOrDefaultAsync(data => data.ID == Guid.Parse(id)); 
    public async Task<T> GetSingleAsync(Expression<Func<T, bool>> method)
        => await Table.FirstOrDefaultAsync(method);

    public IQueryable<T> GetWhere(Expression<Func<T, bool>> method) 
        => Table.Where(method);
}
