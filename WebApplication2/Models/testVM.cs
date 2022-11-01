using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication2.Models
{
    public class testVM
    {
        public int id { get; set; }
        public string Type { get; set; }
        public string Value { get; set; }
        public bool Select { get; set; }

        public IList<RoleClaimtable> climsfromtable { get; set; }

    }
}
