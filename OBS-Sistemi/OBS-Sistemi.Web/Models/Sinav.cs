using System.ComponentModel.DataAnnotations.Schema;

namespace OBS_Sistemi.Web.Models
{
	public class Sinav
	{
		public int SinavID { get; set; }
		public int DersAcmaID { get; set; }
		public string SinavTuru { get; set; }
		public int EtkiOrani { get; set; }
		public DateTime SinavTarihi { get; set; }
		public DateTime SinavSaati { get; set; }
		public int DerslikID { get; set; }
		[ForeignKey(nameof(OgretimElemani))]
		public int OgrElmID { get; set; }


		public DersAcma DersAcma { get; set; }

		public Derslik Derslik { get; set; }

		public OgretimElemani OgretimElemani { get; set; }

		public Degerlendirme Degerlendirme { get; set; }


	}
}
