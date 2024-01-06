using System.ComponentModel.DataAnnotations.Schema;

namespace OBS_Sistemi.Web.Models
{
	public class Bolum
	{
		public int BolumID { get; set; }
		public string BolumAdi { get; set; }
		public string ProgramTuru { get; set; }
		public string OgretimTuru { get; set; }
		public string OgrenimDili { get; set; }
		public string WebAdresi { get; set; }

        public ICollection<Ogrenci> Ogrenciler { get; set; } //Bir bölümde birden çok öğrenci olabilir.

		public ICollection<OgretimElemani> OgretimElemanlari { get; set; } //bir bölümde birden çok öğretim elemanı olabilir.
		
		public Mufredat	Mufredat { get; set; }
	
	
	
	}
}
