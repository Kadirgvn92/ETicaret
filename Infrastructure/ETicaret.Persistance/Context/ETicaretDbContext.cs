using ETicaret.Domain.Entities;
using ETicaret.Domain.Entities.Common;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETicaret.Persistance.Context;
public class ETicaretDbContext : DbContext
{
    public ETicaretDbContext(DbContextOptions options) : base(options) //IOC üzerinden çağırdığımızda ayar yapabilmek için options'lı ctor oluşturuyoruz
    {
    }
    public DbSet<Product> Products { get; set; }
    public DbSet<Order> Orders  { get; set; }
    public DbSet<Customer> Customers  { get; set; }

    //Inceptor yani savechanges dediğimizde araya girip veri güncelelem yapacak method
    public override async Task<int> SaveChangesAsync(CancellationToken cancellationToken = default) 
    {
        //ChangeTracker entittyler üzerinden yapılan değiişiklikleri veya yeni eklenen değişen verileri yakalayan propertileri.
        //Track edilen verileri yakalar.
        var values = ChangeTracker.Entries<BaseEntity>();
        foreach(var item in values)
        {
            _ = item.State switch
            {
                EntityState.Added => item.Entity.CreatedDate = DateTime.UtcNow,
                EntityState.Modified => item.Entity.UpdatedDate = DateTime.UtcNow
            };
        }
        return await base.SaveChangesAsync(cancellationToken);
    }
}
