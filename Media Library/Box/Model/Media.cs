using System.Collections.Generic;

namespace MediaLibrary.Model
{
    public class Media
    {
        public int Id { get; set; }
        public MediaType Type { get; set; }
        public Manufacturer Manufacturer { get; set; }
        public ManufType MType { get; set; }

        public ICollection<Content> Contents { get; set; }
    }
}