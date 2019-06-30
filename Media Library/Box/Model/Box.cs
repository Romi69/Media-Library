using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Infrastructure.Annotations;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaLibrary.Model
{
    public class Box
    {
        public int Id { get; set; }
        public int BoxId { get; set; }
        public string Name { get; set; }
        public int Capacity { get; set; }

        public ICollection<Content> Contents { get; set; }
       
        public Box()
        {
            Contents = new List<Content>();
        }

        public Box(int boxid, String name, int capacity)
        {
            Contents = new List<Content>();

            BoxId = boxid;
            Name = name;
            Capacity = capacity;            
        }        

        public Param ConvertToParam()
        {
            return new Param(paramType: ParamType.Box, paramId: BoxId, intValue: Capacity, stringValue: Name);
        }
    }

    public class BoxConfiguration : EntityTypeConfiguration<Box>
    {
        public BoxConfiguration()
        {
            ToTable("Params");
            Property(d => d.Id).HasColumnName("Id").IsRequired();
            Property(d => d.BoxId).HasColumnName("ParamId").HasColumnAnnotation("Index", new IndexAnnotation(new IndexAttribute()));
            Property(d => d.Name).HasColumnName("StringValue");
            Property(d => d.Capacity).HasColumnName("IntValue");

            HasKey(d => d.Id);
            //HasRequired(d => d.Contents).WithMany(b => b.).Map(m => m.MapKey("BoxId"));
        }
    }
}
