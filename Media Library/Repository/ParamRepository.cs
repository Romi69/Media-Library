using System;
using MediaLibrary.Model;
using System.Data.Entity;

namespace Repository
{
    public class ParamRepository
    {
        private DataContext db;

        public ParamRepository(DataContext db)
        {
            this.db = db;
        }

        public void Add(Param param)
        {
            db.Params.Add(param);
        }

        public Param Find(int Id)
        {
            return db.Params.Find(Id);
        }

        public void Remove(Param oldParam)
        {
            db.Params.Remove(oldParam);
        }

        public void Update(Param oldParam)
        {
            var entry = db.Entry(oldParam);

            if(entry.State == EntityState.Detached)
            {
                db.Set<Param>().Attach(oldParam);
            }

            if(entry.State!= EntityState.Modified)
            {
                entry.State = EntityState.Modified;
            }
            
        }
    }
}