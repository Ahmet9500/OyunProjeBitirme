using Microsoft.AspNetCore.Mvc;
using OyunProjee.Core.Service;
using OyunProjee.Model.Entities;

namespace OyunProjee.WebUI.Controllers
{
    public class KarakterController : Controller
    {
        private readonly IOyunService<Karakter> _k;
        
        public KarakterController(IOyunService<Karakter> k, IOyunService<Oyun> o)
        {
            _k = k;
            
        }

        public IActionResult Listele()
        {

            return View(_k.GetAll());
        }
        public IActionResult Ekle()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Ekle(Karakter k)
        {
            if (k.OyunAdı != null && k.OyuncuAdı != null && k.Gucu != null && k.Vurus != null && k.FızıkselOzellik != null)
            {
                return _k.Add(k) ? View("Listele", _k.GetAll()) : View();
           }
            ViewBag.KarakterError = "Boş bırakılamaz";
            return View();
        }


        public IActionResult Guncelle(int id)
        {
            return View(_k.GetByID(id));
        }

        [HttpPost]
        public IActionResult Guncelle(Karakter a)
        {
            if (a.OyunAdı != null && a.OyuncuAdı != null && a.Gucu != null && a.Vurus != null && a.FızıkselOzellik != null)
            {
                return _k.Update(a) ? View("Listele", _k.GetAll()) : View();
            }
            ViewBag.KarakterError = "Boş bırakılamaz";
            return View();
        }

        public IActionResult Sil(int id)
        {
            return _k.Delete(id) ? View("Listele", _k.GetAll()) : View();
        }




    }
}
