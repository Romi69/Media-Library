using System;
using MediaLibrary.Model;

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
    }
}