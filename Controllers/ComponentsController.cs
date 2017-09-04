using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using menuapp.Models;

namespace menuapp.Controllers
{
    public class ComponentsController : Controller
    {
        public IActionResult DropboxHeroSection()
        {
            return View();
        }
    }
}
