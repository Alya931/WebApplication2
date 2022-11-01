using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication2.Constants;
using WebApplication2.Data;
using WebApplication2.Helpers;
using WebApplication2.Models;
namespace WebApplication2.Controllers.Backend
{
    [Authorize(Roles = "SuperAdmin")]
    public class PermissionController : Controller
    {
        private readonly RoleManager<IdentityRole> _roleManager;
        private readonly ApplicationDbContext _context;

        public PermissionController(RoleManager<IdentityRole> roleManager, ApplicationDbContext context)
        {
            _roleManager = roleManager;
            _context = context;
        }







        public async Task<ActionResult> AllPermission(string roleId)
        {
            var permsion = await _context.RoleClaimtable.ToListAsync();
            var uniq = permsion.GroupBy(x => x.Value).Select(y => y.FirstOrDefault()).Distinct().ToList();
            return View(uniq);
             
        }
        //  [HttpPost]
        //   [ValidateAntiForgeryToken]
        //   public static List<string> GeneratePermissionsForModule(string module)
        //   {
        //      return new List<string>()
        //   {
        //    $"Permissions.{module}.Create",
        //      $"Permissions.{module}.View",
        //    $"Permissions.{module}.Edit",
        //$"Permissions.{module}.Delete",
        //   };
        //   }


        //spart view
        //public async Task<IActionResult> getpermission()
        //{
        //    var employees = await _context.RoleClaims.ToListAsync();
        //    return View(employees);
        //}









        public async Task<ActionResult> Index(string roleId)
        {
            var service = await _context.RoleClaimtable.ToListAsync();
            return View(service);
            //var model = new PermissionViewModel();
            //var allPermissions = new List<RoleClaimsViewModel>();
            //allPermissions.GetPermissions(typeof(Permissions.Products), roleId);
            //allPermissions.GetPermissions(typeof(Permissions.Project), roleId);
            //allPermissions.GetPermissions(typeof(Permissions.Blogs), roleId);
            //allPermissions.GetPermissions(typeof(Permissions.Services), roleId);
            //allPermissions.GetPermissions(typeof(Permissions.Jobs), roleId);

            //var role = await _roleManager.FindByIdAsync(roleId);
            //model.RoleId = roleId;
            //var claims = await _roleManager.GetClaimsAsync(role);
            //var allClaimValues = allPermissions.Select(a => a.Value).ToList();
            //var roleClaimValues = claims.Select(a => a.Value).ToList();
            //var authorizedClaims = allClaimValues.Intersect(roleClaimValues).ToList();
            //foreach (var permission in allPermissions)
            //{
            //    if (authorizedClaims.Any(a => a == permission.Value))
            //    {
            //        permission.Selected = true;
            //    }
            //}
            //model.RoleClaims = allPermissions;
            //return View();
        }
        //  [HttpPost]
        //   [ValidateAntiForgeryToken]
        //   public static List<string> GeneratePermissionsForModule(string module)
        //   {
        //      return new List<string>()
        //   {
        //    $"Permissions.{module}.Create",
        //      $"Permissions.{module}.View",
        //    $"Permissions.{module}.Edit",
        //$"Permissions.{module}.Delete",
        //   };
        //   }


        //spart view
        //public async Task<IActionResult> getpermission()
        //{
        //    var employees = await _context.RoleClaims.ToListAsync();
        //    return View(employees);
        //}







        public async Task<IActionResult> Update(PermissionViewModel model)
        {
            var role = await _roleManager.FindByIdAsync(model.RoleId);
            var claims = await _roleManager.GetClaimsAsync(role);
            foreach (var claim in claims)
            {
                await _roleManager.RemoveClaimAsync(role, claim);
            }
            var selectedClaims = model.RoleClaims.Where(a => a.Selected).ToList();
            foreach (var claim in selectedClaims)
            {
                await _roleManager.AddPermissionClaim(role, claim.Value);
            }
            return RedirectToAction("Index", new { roleId = model.RoleId });
        }

        public async Task<IActionResult> getview()
        {
            var employees = await _context.RoleClaims.ToListAsync();
            return View(employees);
        }


        [HttpPost]
        [ValidateAntiForgeryToken]

        public async Task<IActionResult> Generatepermission(string roleId, string module)
        {//geting id
           

            
            if (ModelState.IsValid)
            {
                try
                {
                    //declare the verible
                    var Permssion1 = "Permissions." + module + ".Create";
                    var Permssion2 = "Permissions." + module + ".View";
                    var Permssion3 = "Permissions." + module + ".Edit";
                    var Permssion4 = "Permissions." + module + ".Delete";

                    //object equal the coming value
                     string[] Permssionarry = { Permssion1 , Permssion2, Permssion3, Permssion4 };
                    var count = Permssionarry.Count();
                    for (var i =0;i<= count-1 ; i++)
                    {
                        var Permssion = new RoleClaimtable();

                        //Permssion.Value = claim;
                        Permssion.Value = (Permssionarry[i]);
                         Permssion.Type = "Permission";
                        _context.RoleClaimtable.Add(Permssion);
                        await _context.SaveChangesAsync();

                        
 
                    }
                }
                catch (DbUpdateConcurrencyException) {
                    throw;
                }
                return RedirectToAction("Index");

            }


            return RedirectToAction("Permission");
        }




        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public async Task<IActionResult> Generatepermission(string roleId, string module)
        //{
        //    var role = await _context.RoleClaims.FindAsync(roleId);
        //     var Permssionadmin = new RoleClaims();

        //    //Permssionadmin = new PermissionViewModel();
        //   if (ModelState.IsValid)
        //   {
        //       try
        //       {

        //            //declare the verible
        //          var Permssion1 = "Permissions."+ module +".Create";
        //          var Permssion2 = "Permissions." + module+ ".View";
        //          var Permssion3 = "Permissions."+ module+".Edit";
        //          var Permssion4 = "Permissions."+module+".Delete";
        //            //object equal the coming value

        //            Permssionadmin.Value = Permssion1;
        //            Permssionadmin.Value = Permssion2;
        //            Permssionadmin.Value = Permssion3;
        //            Permssionadmin.Value = Permssion4;
        //            Permssionadmin.RoleId = roleId;




        //            foreach (var claim in module)
        //            {
        //                Permssionadmin.Value = Permssion1;

        //            }
        //            //add and save changes
        //            _context.Add(Permssionadmin);
        //          await _context.SaveChangesAsync();
        //        }
        //         catch (DbUpdateConcurrencyException)
        //        {
        //           throw;
        //        }

        //     } 
        //}
    }
}