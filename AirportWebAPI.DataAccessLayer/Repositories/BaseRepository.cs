using AirportWebAPI.DataAccessLayer.Model;
using System.Collections.Generic;
using System.Linq;

namespace AirportWebAPI.DataAccessLayer.Repositories
{
    public abstract class BaseRepository<TEntity> where TEntity : BaseModelObject
    {
        protected List<TEntity> list;

        public BaseRepository()
        {
            CreateSeeds();
        }

        public abstract void  CreateSeeds();
        public virtual IEnumerable<TEntity> GetAll()
        {
            return list;
        }
        public virtual TEntity GetById(int id)
        {
            return list.Where(x => x.Id == id).FirstOrDefault();
        }

        public virtual TEntity AddEntry(TEntity entity)
        {
            if (entity != null)
            {
                var maxId = list.Max(x => x.Id);
                entity.Id = (maxId + 1);
                list.Add(entity);
                return entity;
            }
            else return null;
        }

        public virtual TEntity UpdateEntity(TEntity entity)
        {
            var temp = list.Where(x => x.Id == entity.Id).FirstOrDefault();
            if (temp != null)
            {
                list.Remove(temp);
                list.Add(entity);
                return entity;
            }
            else
            {
                return null;
            }
        }

        public virtual TEntity RemoveEntity(int id)
        {
            var temp = list.Where(x => x.Id == id).FirstOrDefault();
            if (temp != null)
            {
                list.Remove(temp);
                return temp;
            }
            else
            {
                return null;
            }
        }
    }
}
