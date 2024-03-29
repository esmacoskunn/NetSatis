﻿using FluentValidation;
using NetSatis.Entities.Interfaces;
using NetSatis.Entities.Tools;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace NetSatis.Entities.Repositories
{
    public class EntityRepositoryBase<TContext, TEntity, TValidator> : IEntityRepositoy<TContext, TEntity>
         where TContext : DbContext, new()
        where TEntity : class, IEntity, new()
        where TValidator : IValidator, new()
    {
        public void AddOrUpdate(TContext context, TEntity entity)
        {
            TValidator validator = new TValidator();
            var validationResult = ValidatorTool.Validate(validator, entity);  //farlklı yazdım
            if (validationResult)
            {
                context.Set<TEntity>().AddOrUpdate(entity);
            }

        }

        public void Delete(TContext context, Expression<Func<TEntity, bool>> filter)
        {
            context.Set<TEntity>().RemoveRange(context.Set<TEntity>().Where(filter));
        }

        public void Save(TContext context)
        {
            context.SaveChanges();
        }
    }
}
