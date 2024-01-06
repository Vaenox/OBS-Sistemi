using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using OBS_Sistemi.Web.Data;
using System.Data.Entity;

namespace OBS_Sistemi.Web.Controllers
{
    public class OgrenciController : Controller
    {
        private readonly MainContext _context;

        public OgrenciController()
        {
            _context = new MainContext();
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult OzlukBilgileri(int kullaniciID)
        {
            var joinedData = from user in _context.tb_Kullanicilar
                             join student in _context.tb_Ogrenciler on user.KullaniciID equals student.KullaniciID
                             join department in _context.tb_Bolumler on student.BolumID equals department.BolumID
                             select new
                             {
                                 UserName = user.KullaniciAdi,
                                 StudentName = student.Adi,
                                 DepartmentName = department.BolumAdi
                                 // Diğer gerekli alanları buraya ekleyebilirsiniz
                             };

            // LINQ sorgusunu çalıştırarak verileri alabiliriz
            var result = joinedData.FirstOrDefault();
            return View(result);
        }
        public IActionResult BolumMufredati()
        {
            return View();
        }
        public IActionResult DonemDersleri()
        {
            return View();
        }
        public IActionResult DersKayit()
        {
            return View();
        }
        public IActionResult DersProgrami()
        {
            return View();
        }        
        public IActionResult SinavTakvimi()
        {
            return View();
        }
        public IActionResult SinavNotlari()
        {
            return View();
        }

        public IActionResult Transkript()
        {
            return View();
        }
        


    }
}
