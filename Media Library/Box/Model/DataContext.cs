using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaLibrary.Model
{
    public class DataContext : DbContext
    {
        public DbSet<Param> Params;
        public DbSet<People> Peoples;
        public DbSet<OutOfBox> OutOfBoxes;
        public DbSet<Media> Medias;
        public DbSet<Content> Contents;
    }
}
