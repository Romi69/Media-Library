using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaLibrary.Model
{
    public enum ParamType { Box, Category, Language, Manufacturer, MediaType, ManufType}
    public class Param
    {
        public int Id { get; set; }
        public ParamType ParamType { get; set; }
        public int ParamId { get; set; }
        public int IntValue { get; set; }
        public double DoubleValue { get; set; }
        public string StringValue { get; set; }

    }
}
