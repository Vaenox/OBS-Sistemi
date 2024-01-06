using System.ComponentModel.DataAnnotations.Schema;

namespace OBS_Sistemi.Web.Models
{
	public class Mufredat
	{
		public int MufredatID { get; set; }
		public int BolumID { get; set; }
		[ForeignKey(nameof(DersHavuzu))]
		public int DersID { get; set; }
		public string AkademikYil { get; set; }
		public string AkademikDonem { get; set; }
		public int DersDonemi { get; set; }

		public Bolum Bolum { get; set; } 

		public DersHavuzu DersHavuzu { get; set; }
	}
}
