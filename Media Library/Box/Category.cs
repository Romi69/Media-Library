using System.Collections.Generic;

namespace MediaLibrary
{
    /// <summary>
    /// Dráma/Krimi/Vígjáték
    /// </summary>
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public ICollection<Media> Contents { get; set; }
    }
}