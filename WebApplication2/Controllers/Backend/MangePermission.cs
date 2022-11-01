using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication2.Data;
using WebApplication2.Models;
using WebApplication2.ViewModels;

namespace WebApplication2.Controllers.Backend
{
    public class MangePermission : Controller
    {
        private readonly RoleManager<IdentityRole> _roleManager;
        private readonly ApplicationDbContext _context;
       private readonly UserManager<IdentityUser> _userManager;
         



        public MangePermission(RoleManager<IdentityRole> roleManager, ApplicationDbContext context, UserManager<IdentityUser> userManager)
        {
      
            _userManager = userManager;

            _roleManager = roleManager;
            _context = context;
        }
        public IActionResult Index(PermissionRoleVM roleVM)
        {
            var users =  _userManager.Users.ToList();
            var permission = _context.RoleClaimtable.ToList();
            
            var uniq = permission.GroupBy(x => x.Value).Select(y => y.FirstOrDefault()).Distinct().ToList();


            var claims = _context.ApplicationRoleClaim.ToList();


            var uniq1 = claims.GroupBy(x => x.ClaimValue).Select(y => y.FirstOrDefault()).Distinct().ToList();


            PermissionRoleVM permissionRoleVM = new PermissionRoleVM()
            {
                Users = users,
                RoleClaimtable = uniq,
            };
            UserClaimsViewModel newPerm = new UserClaimsViewModel()
            {
                Users = users,
                applicationRoleClaims = uniq1
            };
            return View(newPerm);
        }

        //AddOrEdit Post Method
        [HttpPost]
        
        public async Task<IActionResult> CreatePermissonfoUser(UserClaimsViewModel model)

        {

            var users = _userManager.Users.ToList();
            var UserId = "8044ff14-f858-4eb3-a8c6-81fff8eb9b2b";
            var User_ = _userManager.FindByIdAsync(UserId);



            var claims = _context.ApplicationRoleClaim.ToList();
            foreach(var cl in claims)
            {
               
            }




            _userManager.AddClaimAsync(User_, claims[0]);

           // var claims = _userManager.GetClaimsAsync(hi);











            //_context.UserPermission.Add(userPermission);
            //_context.SaveChanges();
            return RedirectToAction(nameof(Index));

        }



        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public async Task<IActionResult> MangeRole(UserRolesViewModel model)
        //{
        //    var User = await _userManager.FindByIdAsync(model.UserId);
        //    if (User == null)

        //        return NotFound();

        //    var userrole = await _userManager.GetRolesAsync(User);
        //    foreach (var role in model.Roles)
        //    {
        //        if (userrole.Any(r => r == role.RoleName) && !role.IsSelected)
        //            await _userManager.RemoveFromRoleAsync(User, role.RoleName);

        //        if (!userrole.Any(r => r == role.RoleName) && role.IsSelected)
        //            await _userManager.AddToRoleAsync(User, role.RoleName);
        //    }

        //    return RedirectToAction(nameof(Index));

        //}

    }
}
