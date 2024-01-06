namespace OBS_Sistemi.Web.Models
{
	public class Derslik
	{
		public int DerslikID { get; set; }
		public string DerslikAdi { get; set; }
		public string DerslikTuru { get; set; }
		public int Kapasite { get; set; }

		public Sinav Sinav { get; set; }
		public DersProgrami DersProgrami { get; set; }
    }

}
