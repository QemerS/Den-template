using Den.Data;
using Den.Models;
using Den.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Den.Controllers
{
    public class HomeController : Controller
    {
        private readonly DenContext _contexct;

        public HomeController(DenContext contexct)
        {
            _contexct = contexct;
        }
        public IActionResult Index()
        {
            HomeVm model = new HomeVm()
            {
                Settings = _contexct.Setting.ToList(),
                Socials = _contexct.Social.ToList()
            };
            return View(model);
        }

       

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
