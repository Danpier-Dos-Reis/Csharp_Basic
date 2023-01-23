using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CsharpApis.Model
{
    public class Country
    {
        public string? Name { get; set; }
        public int Population { get; set; }
        public DateTime Founded  { get; set; }
        public President[]? Presidents { get; set; }
    }

    public class President
    {
        public string? Name { get; set; }
    }
}