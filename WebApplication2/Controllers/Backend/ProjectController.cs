using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication2.Controllers.Backend
{
    [Authorize(Roles = "SuperAdmin")]

    public class ProjectController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
