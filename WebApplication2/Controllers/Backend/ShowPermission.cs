using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication2.Data;

namespace WebApplication2.Controllers.Backend
{
    public class ShowPermission : Controller
    {
         private readonly ApplicationDbContext _context;

        public ShowPermission(ApplicationDbContext context)
        {
             _context = context;
        }

        public async Task    <IActionResult> Index()
            {
            var permsion = await _context.RoleClaimtable.ToListAsync();
            var uniq = permsion.GroupBy(x => x.Value).Select(y => y.FirstOrDefault()).Distinct().ToList();
            return View(uniq);
        }
        }
    }

