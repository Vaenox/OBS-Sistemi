using System.ComponentModel.DataAnnotations.Schema;

namespace OBS_Sistemi.Web.Models
{
	public class OgretimElemani
	{
		public int OgrElmID { get; set; }
		public int BolumID { get; set; }
		public string KurumSicilNo { get; set; }
		public string Unvan { get; set; }
		public string Adi { get; set; }
		public string Soyadi { get; set; }
		public string TCKimlikNo { get; set; }
		public string Cinsiyet { get; set; }
		public DateTime DogumTarihi { get; set; }
		public int KullaniciID { get; set; }

		public Bolum Bolum { get; set; } //Bir öğretim elemanının birden çok bölümü olabilir.
		public Kullanici Kullanici { get; set; } //Bir kullanıcı bir öğretim elemanıdır.
		public DersAcma DersAcma { get; set; }

		public Sinav Sinav { get; set; }
		
        public Danismanlik Danismanlik { get; set; }
    }
}
