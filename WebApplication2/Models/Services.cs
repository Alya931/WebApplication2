using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication2.Models
{
    public class Services
    {
        public int Id { get; set; }
        [NotMapped]
        [DisplayName("Upload File")]
        public IFormFile image { get; set; }

        public string file { get; set; }
        public string link { get; set; }
        public string smallDesc { get; set; }
  
        public string largDesc { get; set; }
        public string title { get; set; }
        public string tag { get; set; }
        public string status { get; set; }
        public bool trash { get; set; }
        public DateTime created_at { get; set; }
        public DateTime updated_at { get; set; }
        public string Catogry { get; set; }

    }
}
