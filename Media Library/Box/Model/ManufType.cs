﻿using System.Collections.Generic;

namespace MediaLibrary.Model
{
    /// <summary>
    /// DVD-R/DVD-R Printable/CD 74min
    /// </summary>
    public class ManufType
    {
        public int Id { get; set; }
        public string Type { get; set; }

        public ICollection<Media> Medias { get; set; }
        public ManufType()
        {
            Medias = new List<Media>();
        }
    }
}