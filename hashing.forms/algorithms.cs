using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hashing.forms
{
    public class algorithms
    {
        public string name { get; set; }
    }

    public class records
    {
        public string access { get; set; }
        public string total { get; set; }
        public string[] names;
        public person[] data { get; set; }
    }

    public class person
    {
        public string name { get; set; }
        public string age { get; set; }
        public string height { get; set; }
    }
}
