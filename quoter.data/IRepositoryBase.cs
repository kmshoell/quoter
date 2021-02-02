using System;
using System.Linq;

namespace quoter.data
{
    //I is "interface" - Defines a contract
    //Any class or struct that implements that contract must provide an implementation of the members defined in the interface.
    //<> is a "generic", we have defined the generic to an arbitrary name TEntity
    //We use generics because they allow us to define a class/method/etc without defining the type until a later time. 
    public interface IRepositoryBase<TEntity>
    {
        //IQueryable is a collection
        IQueryable<TEntity> Get();
        TEntity Get(Guid id);
        TEntity Add(TEntity entity);
        TEntity Update(TEntity entity);
        bool Remove(Guid id);
    }
}
