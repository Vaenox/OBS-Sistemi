using System.ComponentModel.DataAnnotations.Schema;

namespace OBS_Sistemi.Web.Models
{
	public class Danismanlik
	{
		public int DanismanlikID { get; set; }
        [ForeignKey(nameof(OgretimElemani))]
        public int OgrElmID { get; set; }
		public int OgrenciID { get; set; }

		public Ogrenci Ogrenci { get; set; }

		public OgretimElemani OgretimElemani { get; set; }
	}
}
