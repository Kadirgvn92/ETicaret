using ETicaret.Application.Repositories;
using ETicaret.Domain.Entities;
using ETicaret.Persistance.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETicaret.Persistance.Repositories;
public class CustomerReadRepository : ReadRepository<Customer>, ICustomerReadRepository
{
    public CustomerReadRepository(ETicaretDbContext context) : base(context)
    {
    }
}
