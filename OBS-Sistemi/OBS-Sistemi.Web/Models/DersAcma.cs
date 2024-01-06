namespace OBS_Sistemi.Web.Models
{
	public class DersAcma
	{
		public int DersAcmaID { get; set; }
		public string AkademikYil { get; set; }
		public string AkademikDonem { get; set; }
		public int MufreatID { get; set; }
		public int Kontenjan { get; set; }
		public int OgrElmID { get; set; }

		public Mufredat Mufredat { get; set; }
		public ICollection<OgretimElemani> OgretimElemanlari { get; set; } //öğretim elemanları ders açabilir.	
		public DersAlma	DersAlma { get; set; }

		public Sinav Sinav { get; set; }

		public DersProgrami DersProgrami { get; set; }



    }
}
