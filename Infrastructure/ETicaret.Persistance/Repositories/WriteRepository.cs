using ETicaret.Application.Repositories;
using ETicaret.Domain.Entities.Common;
using ETicaret.Persistance.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETicaret.Persistance.Repositories;
public class WriteRepository<T> : IWriteRepository<T> where T : BaseEntity
{
    private readonly ETicaretDbContext _context;

    public WriteRepository(ETicaretDbContext context)
    {
        _context = context;
    }

    public DbSet<T> Table => _context.Set<T>();

    public async Task<bool> AddAsync(T model)
    {
        EntityEntry<T> entry = await Table.AddAsync(model);
        return entry.State == EntityState.Added;
    }
    public async Task<bool> AddRangeAsync(List<T> datas)
    {
        await Table.AddRangeAsync(datas);
        return true;
    }

    public bool Remove(T model)
    {
       EntityEntry entry = Table.Remove(model);
       return entry.State == EntityState.Deleted;
    }
    public bool RemoveRange(List<T> datas)
    {
        Table.RemoveRange(datas);
        return true;
    }
    public async Task<bool> RemoveAsync(string id)
    {
        T model = await Table.FirstOrDefaultAsync(data => data.ID == Guid.Parse(id));
        return Remove(model);
    }
    
    public bool Update(T model)
    {
      EntityEntry entry =  Table.Update(model);
      return entry.State == EntityState.Modified;    
    }
    public async Task<int> SaveAsync(T model) 
        => await _context.SaveChangesAsync();

}
