using System.ComponentModel.DataAnnotations.Schema;

namespace OBS_Sistemi.Web.Models
{
	public class DersAlma
	{
		public int DersAlmaID { get; set; }
		public int DersAcmaID { get; set; }
		[ForeignKey(nameof(Ogrenci))]
		public int OgrenciID { get; set; }
		public char Durum { get; set; }

		public DersAcma DersAcma { get; set; }
		public ICollection<Ogrenci> Ogrenciler { get; set;}//bir dersi birden çok öğrenci alabilir.
	}
}
