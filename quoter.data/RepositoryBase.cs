using System;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using quoter.model;

namespace quoter.data
{
    //boilerplate class for CRUD operations
    //Implements contract with IRepositoryBase

    //Whoever implements class will have to pass TEntity (int, obj, etc.) and a TContext (a generic context/interface to the db)
    public abstract class RepositoryBase<TEntity, TContext> : IRepositoryBase<TEntity>
        //Defines TContext to be
        where TContext : DbContext, IQuoterContext
        //Defines TEntity as a class and that class must have a default constructor defined (new())
        where TEntity : class, IIdentifiableEntity, ISoftDeletable, new()
    {

        //context is the interface with the db.
        public abstract TContext context { get; }
        //DBSet<TEntity> can be used to query and save the instance of TEntity
        //TEntity is a class (See line 15), these classes (Company, Users, etc) map to tables on the db.
        //DBSet is essentially a query to the database about the TEntity class
        //EntityFramework is an ORM
        public abstract DbSet<TEntity> dbSet { get;  }
        public RepositoryBase() 
        {
        }

        public TEntity Add(TEntity entity)
        {
            //Get context and save changes
            dbSet.Add(entity);
            context.SaveChanges();
            return entity;
        }

        public IQueryable<TEntity> Get()
        {
            return dbSet.Where(entity => entity.IsDeleted == false);
        }

        public TEntity Get(Guid key)
        {
            //Runs Get method and then finds first or default entity by key
            return Get().FirstOrDefault(entity => entity.Id == key);
        }

        public bool Remove(Guid key)
        {
            var entity = Get(key);
            if(entity != null)
            {
                entity.IsDeleted = true;
                context.SaveChanges();
                return true;
            }
            return false;
        }

        public TEntity Update(TEntity entity)
        {
            context.Update(entity);
            context.SaveChanges();
            return entity;
        }
    }
}
