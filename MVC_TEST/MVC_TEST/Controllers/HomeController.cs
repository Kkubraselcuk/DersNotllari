using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MVC_TEST.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace MVC_TEST.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }
        public string Metin()
        {
            return "Kitap controller sınıfındaki Index metodu çalıştı";
        }

        public JsonResult JsonCikti()
        {
            return Json(new
            {
                Id = 1,
                Seviye = "11. Sınıf",
                KitapAdi = "WEB TABANLI UYGULAMA GELİŞTİRME"
            });
        }

        public FileResult Resim()
        {
            return File("~/meblogo.png", "image/png");
        }

        //Kitap/Liste/1
        public string Liste(int id)
        {
            return $"Parametreden gelen değer: {id}";
        }


        //Kitap/Liste/1/MEB 
        [Route("Kitap/Liste/{id}/{ad}")]
        public string Liste(int id, string ad)
        {
            return $"Parametreden gelen id={id}, ad={ad}";
        }









        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
