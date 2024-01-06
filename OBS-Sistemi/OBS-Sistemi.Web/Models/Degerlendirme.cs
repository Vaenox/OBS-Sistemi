namespace OBS_Sistemi.Web.Models
{
	public class Degerlendirme
	{
		public int DegerlendirmeID { get; set; }
		public int SinavID { get; set; }
		public int OgrenciID { get; set; }
		public double SinavNotu { get; set; }

		public Sinav Sinav {  get; set; }

		public Ogrenci Ogrenci { get; set;}
	}
}
