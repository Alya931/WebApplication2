using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using WebApplication2.Models;

namespace WebApplication2.Data
{
    public class ApplicationDbContext : IdentityDbContext<IdentityUser, IdentityRole, string,
        IdentityUserClaim<string>, IdentityUserRole<string>, IdentityUserLogin<string>,
        ApplicationRoleClaim, IdentityUserToken<string>>

    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        
         public DbSet<RoleClaim> RoleClaim { get; set; }
        public DbSet<Services> Services { get; set; }
        public DbSet<UserPermission> UserPermission { get; set; }
        public DbSet<RoleClaimtable> RoleClaimtable { get; set; }

        public DbSet<ApplicationRoleClaim> ApplicationRoleClaim { get; set; }
            

        internal Task GetClaimsAsync(object role)
        {
            throw new NotImplementedException();
        }
    }
}
