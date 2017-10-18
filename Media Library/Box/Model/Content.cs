using System;
using System.Collections.Generic;

namespace MediaLibrary.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class Content
    {
        public int Id { get; set; }
        public Media ContMedia { get; set; }
        public Box Box { get; set; }
        public int Position { get; set; }
        public string Title { get; set; }
        public string HungarianTitle { get; set; }
        public Category Category { get; set; }
        public DateTime CreationDate { get; set; }
        public ICollection<Language> Audio{ get; set; }
        public ICollection<Language> Subtitle { get; set; }
        // Szikronizált?
        public bool HasMainLang { get;}
        public int Length { get; set; }
        public int MyRate { get; set; }
        public DateTime LastView { get; set; }
        // Kölcsönadva
        public OutOfBox OutOfBox { get; set; }
        public ICollection<People> Directors { get; set; }
        public ICollection<People> Actors { get; set; }
        public string Comment { get; set; }
        public bool MarkForDelete { get; set; }

        public Content()
        {
            Audio = new List<Language>();
            Subtitle = new List<Language>();
            Directors = new List<People>();
            Actors = new List<People>();
        }
    }
}