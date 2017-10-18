using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaLibrary.Model
{
    public class Box
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Capacity { get; set; }

        public ICollection<Content> Contents { get; set; }

        public Box()
        {
            Contents = new List<Content>();
        }
    }
}
