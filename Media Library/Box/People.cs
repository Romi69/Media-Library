using System.Collections.Generic;

namespace MediaLibrary
{
    public class People
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Nationality { get; set; }


        public ICollection<Media> Contents { get; set; }
    }
}