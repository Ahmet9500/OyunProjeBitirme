using Microsoft.AspNetCore.Mvc;
using OyunProjee.Core.Service;
using OyunProjee.Model.Entities;

namespace OyunProjee.WebUI.Controllers
{
    public class KullanıcıKontroller:Controller
    {
        private readonly IOyunService<Kullanıcı> _ku;
        public KullanıcıKontroller(IOyunService<Kullanıcı> ku)
        {
            _ku = ku;
        }
        public IActionResult Listele()
        {
            return View(_ku.GetAll());
        }
        public IActionResult Ekle()
        {
            return View();
        }
    }
}
