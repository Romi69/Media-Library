﻿using System;
using System.Collections.Generic;

namespace MediaLibrary
{
    /// <summary>
    /// Kölcsönadva
    /// </summary>
    public class OutOfBox
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public string NameOfPerson { get; set; }
        public string Comment { get; set; }

        public ICollection<Content> Contents { get; set; }
    }
}