using System;
using MediaLibrary.Model;
using System.Data.Entity;

namespace Repository
{
    public class GeneralRepository<TEntity> 
        where TEntity : class
    {
        private DataContext db;

        public GeneralRepository(DataContext db)
        {
            this.db = db;
        }

        public void Add(TEntity entity)
        {
            db.Set<TEntity>().Add(entity);
        }

        public TEntity Find(params object[] keys)
        {
            return db.Set<TEntity>().Find(keys);
        }

        public void Remove(TEntity entity)
        {
            db.Set<TEntity>().Remove(entity);
        }

        public void Update(TEntity entity)
        {
            var entry = db.Entry(entity);

            if(entry.State == EntityState.Detached)
            {
                db.Set<TEntity>().Attach(entity);
            }

            if(entry.State!= EntityState.Modified)
            {
                entry.State = EntityState.Modified;
            }            
        }
    }
}