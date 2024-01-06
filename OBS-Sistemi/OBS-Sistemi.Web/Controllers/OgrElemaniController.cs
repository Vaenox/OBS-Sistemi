using Microsoft.AspNetCore.Mvc;

namespace OBS_Sistemi.Web.Controllers
{
    public class OgrElemaniController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult BolumMufredati()
        {
            return View();
        }
        public IActionResult VerilenDersler() 
        { 
            return View(); 
        }
        public IActionResult DersProgrami()
        {
            return View();
        }
        public IActionResult DersKayitOnayi()
        {
            return View();
        }
        public IActionResult SinavTakvimi()
        {
            return View();
        }
        public IActionResult SinavTanimla()
        {
            return View();
        }
        public IActionResult Degerlendirme()
        {
            return View();
        }
        public IActionResult Danismanlik()
        {
            return View();
        }
        public IActionResult OzlukBilgileri()
        {
            return View();
        }
        public IActionResult Mesajlar()
        {
            return View();
        }

    }
}
