using AirportWebAPI.DataAccessLayer.Model;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace AirportWebAPI.DataAccessLayer.Interfaces
{
    public interface IRepository<TEntity> where TEntity : BaseModelObject
    {
        IEnumerable<TEntity> GetAll();
        TEntity GetById(int id);

        TEntity AddEntry(TEntity entity);

        TEntity UpdateEntity(TEntity entity);

        TEntity RemoveEntity(int id);
    }
}
