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

        public GeneralRepository<Param> ParamRepository { get; set; }
        public GeneralRepository<People> PeopleRepository { get; set; }

        public UnitOfWork()
        {
            db = new DataContext();
            ParamRepository = new GeneralRepository<Param>(db);
            PeopleRepository = new GeneralRepository<People>(db);
        }

        public void Save()
        {
            db.SaveChanges();
        }

        public int GetNextParamTypeId(ParamType paramType)
        {
            var x = db.Params.Max("ParamId", x => x.ParamType == paramType, true);
            return ParamRepository.Find(x).ParamId;
        }
    }
}
