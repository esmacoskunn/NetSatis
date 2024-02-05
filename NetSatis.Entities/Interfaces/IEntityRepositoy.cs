using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace NetSatis.Entities.Interfaces
{
    public interface IEntityRepositoy<TContext, TEntity>
           where TContext : DbContext, new()
           where TEntity : class, IEntity, new() //diğer claslardan ayırt etmek için bunlara IEntity dedik. 
    {
        void AddOrUpdate(TContext context, TEntity entity);
        void Delete(TContext context, Expression<Func<TEntity, bool>> filter);
        void Save(TContext context);

    }
}
