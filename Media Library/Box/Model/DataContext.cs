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
        public DbSet<Param> Params { get; set; }
        public DbSet<People> Peoples { get; set; }
        public DbSet<OutOfBox> OutOfBoxes { get; set; }
        public DbSet<Media> Medias { get; set; }
        public DbSet<Content> Contents { get; set; }


        public DataContext() : base("name=MediaLibrary")
        {

        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //modelBuilder.Entity<Box>().Map<Param>(c => c.Requires("ParamType").HasValue(ParamType.Box));
            modelBuilder.Entity<Box>().ToTable("Params");
            base.OnModelCreating(modelBuilder);
        }
    }
}
