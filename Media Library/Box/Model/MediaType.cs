using System.Collections.Generic;

namespace MediaLibrary.Model
{
    /// <summary>
    /// CD/DVD/BD/Digital8/...
    /// </summary>
    public class MediaType
    {
        public int Id { get; set; }
        public string Type { get; set; }

        public ICollection<Media> Medias { get; set; }
        public MediaType()
        {
            Medias = new List<Media>();
        }

    }
}