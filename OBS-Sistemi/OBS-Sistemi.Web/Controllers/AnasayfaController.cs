using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Storage;
using OBS_Sistemi.Web.Models;
using OBS_Sistemi.Web.Data;

namespace OBS_Sistemi.Web.Controllers
{
	public class AnasayfaController : Controller
	{
		private readonly MainContext _context;

        public AnasayfaController() 
		{ 
			 _context = new MainContext();
		}
	           
        public IActionResult Index()
		{
			return View();
		}
        [HttpPost]
        public IActionResult Index(string userName, string password, Kullanici kullanici) 
        {
              
            return CheckIsUserValid(userName, password, kullanici.KullaniciID);
        }
        public void SaveUser(string userName, string password)
        {
            CheckUserName(userName);
            CheckPassword(password);

            Kullanici newUser = new Kullanici()
            {
                KullaniciAdi = userName,
                Parola = password,
                KullaniciTuru = "Öğrenci"
            };
            _context.Add(newUser);
            _context.SaveChanges();
        }
        public IActionResult CheckIsUserValid(string userName, string password,int kullaniciId)
		{
			CheckUserName(userName);
            CheckPassword(password);

            
            Kullanici? kullanici = _context.tb_Kullanicilar.FirstOrDefault(ax => ax.KullaniciAdi == userName);
            //List<Kullanici> kullanicilar = _context.tb_Kullanicilar.ToList(); // Tablodaki tüm kayıtları getiri.
            if (kullanici == null)
			{
                // Böyle bir kullanıcı yok.
                throw new Exception("Böyle bir kullanıcı yok.");
            }

			bool isPasswordMatched = kullanici.Parola == password;
            if (!isPasswordMatched)
            {
                // Kullanıcı var ama şifresi hatalı.
                throw new Exception("Kullanıcı var ama şifresi hatalı.");
            }

            CheckUserType(kullanici.KullaniciTuru);
            // Kullanıcı adı ve şifresi doğru, girişe yönlendirebiliriz:

            bool isTeacher = kullanici.KullaniciTuru == "Öğretim Elemanı";
		
            bool isStudent = kullanici.KullaniciTuru == "Öğrenci";
            if (isStudent)
            {
               return RedirectToAction("Index", "Ogrenci", new { kullaniciId });
            }
            else if (isTeacher)
            {
               return RedirectToAction("Index", "OgrElemani", new { kullaniciId });
            }
            else 
            {
                return RedirectToAction("Index", "Anasayfa", new { kullaniciId });
            }

        }

		private void CheckUserName(string userName)
		{
            if (string.IsNullOrWhiteSpace(userName))
                throw new ArgumentNullException(nameof(userName));
        }

        private void CheckPassword(string password)
        {
            if (string.IsNullOrWhiteSpace(password))
                throw new ArgumentNullException(nameof(password));
        }
		private void CheckUserType(string userType)
		{
            bool isTeacher = userType == "Öğretim Elemanı";
            bool isStudent = userType == "Öğrenci";
			if (!isTeacher && !isStudent)
			{
				throw new Exception("Bu kullanıcının tipi belirsiz.");
			}
        }

    }
}
