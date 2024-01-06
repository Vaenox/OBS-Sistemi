namespace OBS_Sistemi.Web.Models
{
	public class Kullanici
	{
		
		public int KullaniciID { get; set; }
        public string KullaniciAdi { get; set; }
        public string Parola { get; set; }
		public string KullaniciTuru { get; set; }


		public Ogrenci Ogrenci { get; set; }//Bir öğrenci bir kullanıcıdır.

		public OgretimElemani OgretimElemani { get; set; }//Bir öğretim elemanının bir kullanıcıdır.
	
	}
}
