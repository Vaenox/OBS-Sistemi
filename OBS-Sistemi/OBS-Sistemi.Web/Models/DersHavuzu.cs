using System.ComponentModel.DataAnnotations.Schema;

namespace OBS_Sistemi.Web.Models
{
	public class DersHavuzu
	{
		public int DersID { get; set; }
		public string DersKodu { get; set; }
		public string DersAdi { get; set; }
		public string DersDili { get; set; }
		public string DersSeviyesi { get; set; }
		public string DersTuru { get; set; }
		public int Teorik { get; set; }
		public int Uygulama { get; set; }
		public double Kredi { get; set; }
		public int ECTS { get; set; }
		
		public Mufredat Mufredat { get; set; }
	}
}
