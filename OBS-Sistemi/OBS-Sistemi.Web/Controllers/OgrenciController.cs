using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using OBS_Sistemi.Web.Data;
using OBS_Sistemi.Web.Models;
using System.Data.Entity;

namespace OBS_Sistemi.Web.Controllers
{
    public class OgrenciController : Controller
    {
        private readonly MainContext _context;//dependency injection
        

        public OgrenciController()
        {
            _context = new MainContext();
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult OzlukBilgileri(int kullaniciId)
        { 
            
            var joinedData = from user in _context.tb_Kullanicilar
                             join student in _context.tb_Ogrenciler on user.KullaniciID equals student.KullaniciID
                             join department in _context.tb_Bolumler on student.BolumID equals department.BolumID
                             where student.KullaniciID == kullaniciId


                             select new
                             {
                                 UserName = user.KullaniciAdi,
                                 StudentName = student.Adi,
                                 DepartmentName = department.BolumAdi
                                 // Diğer gerekli alanları buraya ekleyebilirsiniz
                             };

            // LINQ sorgusunu çalıştırarak verileri alabiliriz
            var result =joinedData.FirstOrDefault();

            return View();
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
