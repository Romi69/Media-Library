using MediaLibrary.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class UnitOfWork
    {
        private DataContext db;

        public ParamRepository ParamRepository { get; set; }

        public UnitOfWork()
        {
            db = new DataContext();
            ParamRepository = new ParamRepository(db);
        }

        public void Save()
        {
            db.SaveChanges();
        }
    }
}
