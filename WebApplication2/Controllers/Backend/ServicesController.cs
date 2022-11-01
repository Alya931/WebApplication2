using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication2.Data;
using static WebApplication2.Constants.Permissions;

namespace WebApplication2.Controllers.Backend
{
    [Authorize(Roles = "SuperAdmin")]

    public class ServicesController : Controller
    {

        private readonly ApplicationDbContext _context;
        public ServicesController(ApplicationDbContext context)
        {
            _context = context;
        }



        public async Task<IActionResult> Index()
        {
            var service = await _context.Services.ToListAsync();
            return View(service);
        }

        //AddOrEdit Get Method
        public async Task<IActionResult> create(int? Id)
        {
     
            return View();

        }

        //AddOrEdit Post Method
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> create([Bind("Id,image,file,link,smallDesc,largDesc,title,tag,status,trash,Catogry,updated_at,created_at")]
Models.Services servicesdata)
        {
            _context.Services.Add(servicesdata);
            _context.SaveChanges();
            var service = await _context.Services.ToListAsync();
            return View("/Views/Services/Index.cshtml", service);

        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Update([Bind("Id,image,file,link,smallDesc,largDesc,title,tag,status,trash,Catogry,updated_at,created_at")]
Models.Services servicesdata)
        {
            _context.Services.Update(servicesdata);
            _context.SaveChanges();
            return View("Views/backend/Services/Index");
        }


        
        public async Task<IActionResult> Update(int Id)
        {

            var serc = await _context.Services.FirstOrDefaultAsync(m => m.Id == Id);


            return View(serc);

        }
        public async Task<IActionResult> Details(int Id)
        {

            var serc = await _context.Services.FirstOrDefaultAsync(m => m.Id == Id);


            return View(serc); 

        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Delete(int Id)
        {
            var services = await _context.Services.FindAsync(Id);

            _context.Services.Remove(services);
            _context.SaveChanges();
            var servicaaae = await _context.Services.ToListAsync();

            return View("/Views/Services/Index.cshtml", servicaaae);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> UpdateProfile(int Id, [Bind("Id,image,file,link,smallDesc,largDesc,title,tag,status,trash,Catogry,updated_at,created_at")]
Models.Services servicesdata)
        {


            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(servicesdata);
                    await _context.SaveChangesAsync();

                }
                catch (DbUpdateConcurrencyException)
                {

                    throw;
                }
                var servicess = await _context.Services.ToListAsync();

                return View("/Views/Services/Index.cshtml", servicess);

                return Redirect("~/Services/Index");


            }
            var service = await _context.Services.ToListAsync();
                                    return Redirect("~/Services/Index");

 

        }
    }
}
