using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace My.IdentityServer.Controllers
{
    public class GrantController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}