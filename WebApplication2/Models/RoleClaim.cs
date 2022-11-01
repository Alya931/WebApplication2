using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;


namespace WebApplication2.Models
{
    public class RoleClaim
    {
       [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }
        public string Type { get; set; }
        public string Value { get; set; }
        public bool Select { get; set; }

    }
}
