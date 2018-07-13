using AirportWebAPI.BusinessLayer.DTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace AirportWebAPI.BusinessLayer.Interfaces
{
    public interface IService<TEntity> where TEntity : BaseObject
    {
        List<TEntity> GetAll();
        TEntity GetById(int id);
        TEntity AddEntry(TEntity entity);
        TEntity RemoveEntry(int id);
        TEntity UpdateEntry(TEntity entity);
    }
}
