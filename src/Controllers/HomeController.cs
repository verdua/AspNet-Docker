using System;
using System.Diagnostics;
using System.Net;
using Microsoft.AspNetCore.Mvc;
using src.Models;
using src.Models.Home;

namespace src.Controllers
{
    public class HomeController : Controller
    {
        #region Routes
        public IActionResult Index()
        {
            IPAddress ip = HttpContext.Connection.RemoteIpAddress;
            IndexViewModel viewModel = new IndexViewModel(DateTime.Now, ip.ToString());
            
            return View(viewModel);
        }

        public IActionResult AspNet()
        {
            return View();
        }

        public IActionResult Docker()
        {
            return View();
        }

        public IActionResult DockerNet()
        {
            return View();
        }

        public IActionResult About()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        #endregion Routes
    }
}
