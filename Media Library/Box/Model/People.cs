using System.Collections.Generic;

namespace MediaLibrary.Model
{
    public class People
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Nationality { get; set; }


        public ICollection<Content> Contents { get; set; }
    }
}