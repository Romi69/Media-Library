using System.Collections.Generic;

namespace MediaLibrary
{
    /// <summary>
    /// Angol/Francia/Magyar
    /// </summary>
    public class Language
    {
        public int Id { get; set; }
        public string Type { get; set; }

        public ICollection<Media> Contents{ get; set; }
    }
}