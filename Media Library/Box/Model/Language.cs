using System.Collections.Generic;

namespace MediaLibrary.Model
{
    /// <summary>
    /// Angol/Francia/Magyar
    /// </summary>
    public class Language
    {
        public int Id { get; set; }
        public string Type { get; set; }

        public ICollection<Content> Contents{ get; set; }
    }
}