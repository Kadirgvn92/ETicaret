using ETicaret.Domain.Entities.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ETicaret.Application.Repositories;
public interface IReadRepository<T> : IRepository<T> where T : BaseEntity
{
    IQueryable<T> GetAll(bool tracking = true); //bool tracking işlemi ef tracking optimizasyonu amacıyla yazdık
    IQueryable<T> GetWhere(Expression<Func<T,bool>> method, bool tracking = true);
    Task<T> GetSingleAsync(Expression<Func<T,bool>> method, bool tracking = true);
    Task<T> GetByIDAsync(string id, bool tracking = true);
}
