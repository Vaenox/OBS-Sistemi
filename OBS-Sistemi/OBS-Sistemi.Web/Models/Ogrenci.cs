namespace OBS_Sistemi.Web.Models
{
	public class Ogrenci
	{
		public int OgrenciID { get; set; }
		public int BolumID { get; set; }
		public string OgrenciNo { get; set; }
		public string Durumu { get; set; }
		public DateTime KayitTarihi { get; set; }
		public DateTime AyrilmaTarihi { get; set; }
		public string Adi { get; set; }
		public string Soyadi { get; set; }
		public string TCKimlikNo { get; set; }
		public string Cinsiyet { get; set; }
		public DateTime DogumTarihi { get; set; }
		public int KullaniciID { get; set; }
        public Bolum Bolum { get; set; } //bir kişinin tek bir bölümü olabilir.

		public Kullanici Kullanici { get; set; }//Bir Öğrenci bir kullanıcıdır.

		public DersAlma DersAlma { get; set; }

		public Degerlendirme Degerlendirme { get; set; }

		public Danismanlik Danismanlik { get; set; }
    }
}
