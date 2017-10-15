﻿using System.Collections.Generic;

namespace MediaLibrary
{
    /// <summary>
    /// CD/DVD/BD/Digital8/...
    /// </summary>
    public class MediaType
    {
        public int Id { get; set; }
        public string Type { get; set; }

        public ICollection<Media> Medias { get; set; }

    }
}