using Microsoft.AspNetCore.Mvc;
using OyunProjee.Core.Service;
using OyunProjee.Model.Entities;

namespace OyunProjee.WebUI.Controllers
{
    public class OyunController : Controller
    {
        private readonly IOyunService<Oyun> _oyun;
        public OyunController(IOyunService<Oyun> oyun)
        {
            _oyun = oyun;
        }
        public IActionResult Listele()
        {
            return View(_oyun.GetAll());
        }
        public IActionResult Ekle()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Ekle(Oyun o)
        {
            if (o.OyunAdı != null && o.KurulusTarihi != null && o.Türü != null && o.Fiyat != null)
            {
                return _oyun.Add(o) ? View("Listele",_oyun.GetAll()) : View();
            }
            ViewBag.OyunAddError = "Boş bırakılamaz";
            return View();
        }

        public IActionResult Guncelle(int id)
        {
            return View(_oyun.GetByID(id));
        }

        [HttpPost]
        public IActionResult Guncelle(Oyun o)
        {
            if (o.OyunAdı != null && o.KurulusTarihi != null && o.Türü != null & o.Fiyat != null) {
                return _oyun.Update(o) ? View("Listele", _oyun.GetAll()) : View();
            }
            ViewBag.OyunAddError = "Boş bırakılamaz";
            return View();
        }

        public IActionResult Sil(int id)
        {
            return _oyun.Delete(id) ? View("Listele", _oyun.GetAll()) : View();
        }



    }
}
