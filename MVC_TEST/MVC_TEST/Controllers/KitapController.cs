using Microsoft.AspNetCore.Mvc;
using MVC_TEST.Models;
using System.Collections.Generic;
using System.Text.Json;

namespace MVC_TEST.Controllers
{
    public class KitapController : Controller
    {
        //6.2.4.2. Action Metottan View'e Veri Aktarımı
        public IActionResult Index()
        {
            
            var kitap = new List<KitapModel>
            {
               new KitapModel{ KitapId =1, KitapAdi="kitap 1", SayfaSayisi=100},
               new KitapModel{ KitapId =1, KitapAdi="kitap 2", SayfaSayisi=200},
               new KitapModel{ KitapId =1, KitapAdi="kitap 3", SayfaSayisi=300},
            };
            #region Model bazlı veri gönderilmesi
            //return View(kitap);
            #endregion;

            #region Veri Taşıma Kontrolleri

            #region ViewBag
            //ViewBag.Baslik = "ViewBag ile veri gönderilmesi";
            //ViewBag.Kitap = kitap;
            #endregion

            #region ViewData
            ViewData["Baslik"] = "ViewData ile veri gönderilmesi";
            ViewData["Kitap"] = kitap;
            #endregion

            #region TempData
            TempData["Baslik"] = "TempData ile veri gönderilmesi";
            TempData["Kitap"] = kitap;
            #endregion

            #endregion;
            return View();
        }
        public IActionResult Index2()
        {
            #region Tempdata başka bir actiona veri gönderimi örneği
            ViewBag.x = 5;
            ViewData["x"] = 5;
            TempData["x"] = 5;
            #endregion
            //RedirectToAction(Action, Controller);
            return RedirectToAction("Index3");
        }
        public IActionResult Index3()
        {
            var x1 = ViewBag.x;
            var x2 = ViewData["x"];
            var x3 = TempData["x"];
            return View();
        }

        // karmaşık yapıdaki verileri tempdata ile göndermek için
        public IActionResult Index4()
        {
            var kitap = new List<KitapModel>
            {
               new KitapModel{ KitapId =1, KitapAdi="kitap 1", SayfaSayisi=100},
               new KitapModel{ KitapId =1, KitapAdi="kitap 2", SayfaSayisi=200},
               new KitapModel{ KitapId =1, KitapAdi="kitap 3", SayfaSayisi=300},
            };
            string data = JsonSerializer.Serialize(kitap);
            TempData["kitaplar"] = data;
            return View();
        }
        public IActionResult Index5()
        {
            var data = TempData["kitaplar"].ToString();
            List<KitapModel> kitaplar = JsonSerializer.Deserialize<List<KitapModel>>(data);
            return View();
        }
        public IActionResult Kategoriler()
        {
            return View();
        }
        public IActionResult KitapListesi(int id)
        {
            return View();
        }


    }
}
