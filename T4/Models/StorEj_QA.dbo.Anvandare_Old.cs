// This class was automatically generated with love by ST4bby 2013-05-01 20:47:40.
// Read more at http://jbubriski.github.com/ST4bby/

namespace MySt4bbyNamespace
{
	using System;
	using System.ComponentModel.DataAnnotations;
	
	public class Anvandare_Old
	{
		[Key, Required, Display(Name="Anvandare ID")]
		public int AnvandareID { get; set; }
		
		[Display(Name="Tillhor Grupp ID")]
		public Nullable<int> TillhorGruppID { get; set; }
		
		[Display(Name="Bolag ID")]
		public Nullable<int> BolagID { get; set; }
		
		[Required, Display(Name="Namn")]
		public string Namn { get; set; }
		
		[Required, Display(Name="Anvandarnamn"), StringLength(100)]
		public string Anvandarnamn { get; set; }
		
		[Required, Display(Name="Losenord"), StringLength(100)]
		public string Losenord { get; set; }
		
		[Required, Display(Name="Epostadress")]
		public string Epostadress { get; set; }
		
		[Required, Display(Name="Prenumerera")]
		public bool Prenumerera { get; set; }
		
		[Required, Display(Name="Antal Misslyckade Paloggningar")]
		public int AntalMisslyckadePaloggningar { get; set; }
		
		[Required, Display(Name="Senaste Paloggninsforsok")]
		public DateTime SenastePaloggninsforsok { get; set; }
		
		[Required, Display(Name="Last")]
		public bool Last { get; set; }
	}
}
