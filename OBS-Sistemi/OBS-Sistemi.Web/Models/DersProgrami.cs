namespace OBS_Sistemi.Web.Models
{
	public class DersProgrami
	{
		public int DersPrgID { get; set; }
		public int DersAcmaID { get; set; }
		public int DerslikID { get; set; }
		public string DersGunu { get; set; }
		public int DersSaati { get; set; }

		public DersAcma DersAcma { get; set; }
		public Derslik Derslik { get; set; }
	}
}
