using System.Collections.Generic;

namespace MediaLibrary.Model
{
    /// <summary>
    /// Verbatim/TDK/Philips
    /// </summary>
    public class Manufacturer
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public ICollection<Media> Medias { get; set; }
    }
}