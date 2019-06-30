using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaLibrary.Model
{
    public interface ISourceType
    {
        Type DestinationType { get; set; }
        public int RecordType { get; set; }
    }
}
