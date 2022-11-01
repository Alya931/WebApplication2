using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;


namespace WebApplication2.Models
{
    public class PermissionRoleVM
    {
         public List<IdentityUser> Users{ get; set; }

        public List<RoleClaimtable> RoleClaimtable { get; set; }
        public List<Checklist> Checklist { get; set; }



    }
}