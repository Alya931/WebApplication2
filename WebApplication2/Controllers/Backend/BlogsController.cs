using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication2.Controllers.Backend
{

    public class BlogsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
