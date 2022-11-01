using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication2.Models
{
    public class ServicesViewModel
    {
         [Required(ErrorMessage = "Please enter first name")]  
        [Display(Name = "First Name")]  
        public string link { get; set; }  
  
        [Required(ErrorMessage = "Please enter last name")]  
        [Display(Name = "First Name")]  
        public string smallDesc { get; set; }  
  
        [Required(ErrorMessage = "Please enter age")]  
        public int largDesc { get; set; }  
  
        [Required(ErrorMessage = "Please choose gender")]  
        public string title { get; set; }  
  
        [Required(ErrorMessage = "Please enter position")]  
        public string tag { get; set; }  
  
        [Required(ErrorMessage = "Please enter office")]  
        public string Catogry { get; set; }  
  
 
  
        [Required(ErrorMessage = "Please choose profile image")]  
        [Display(Name = "Service Picture")]  
        public IFormFile image { get; set; }

        [Required(ErrorMessage = "Please choose profile file")]
        [Display(Name = "Service File")]
        public IFormFile file { get; set; }
    }
}
