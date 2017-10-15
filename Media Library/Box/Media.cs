using System.Collections.Generic;

namespace MediaLibrary
{
    public class Media
    {
        public int Id { get; set; }
        public MediaType Type { get; set; }
        public Manufacturer Manufacturer { get; set; }
        public MunafType MType { get; set; }

        public ICollection<Content> Contents { get; set; }
    }
}