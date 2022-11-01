using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication2.Models
{
    public class PermissionViewModel
    {
        public string RoleId { get; set; }
        public IList<RoleClaimsViewModel> RoleClaims { get; set; }

        public static implicit operator PermissionViewModel(IdentityRole v)
        {
            throw new NotImplementedException();
        }
    }
    public class RoleClaimsViewModel
    {
        public string Type { get; set; }
        public string Value { get; set; }
        public bool Selected { get; set; }
 
        
    }
}
