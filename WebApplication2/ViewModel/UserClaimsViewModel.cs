using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication2.Models;

namespace WebApplication2.ViewModels
{
    public class UserClaimsViewModel
    {
        public UserClaimsViewModel()
        {
            Cliams = new List<UserClaim>();
        }
        public List<RoleClaimtable> RoleClaimtable { get; set; }

        public List<IdentityUser> Users { get; set; }
        public string UserId { get; set; }
        public List<ApplicationRoleClaim> applicationRoleClaims { get; set; }
        public List<UserClaim> Cliams { get; set; }
    }
}
