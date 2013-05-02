// This class was automatically generated with love by ST4bby 2013-05-01 20:47:40.
// Read more at http://jbubriski.github.com/ST4bby/

namespace MySt4bbyNamespace
{
	using System;
	using System.ComponentModel.DataAnnotations;
	
	public class Tillsynsplanering
	{
		[Key, Required, Display(Name="Tillsynsplanering ID")]
		public int TillsynsplaneringID { get; set; }
		
		[Required, Display(Name="Bestallning ID")]
		public int BestallningID { get; set; }
		
		[Required, Display(Name="Omplanering Tillaten")]
		public bool OmplaneringTillaten { get; set; }
		
		[Required, Display(Name="Dag")]
		public bool Dag { get; set; }
		
		[Required, Display(Name="Start")]
		public DateTime Start { get; set; }
		
		[Required, Display(Name="Slut")]
		public DateTime Slut { get; set; }
		
		[Required, Display(Name="Kommentar")]
		public string Kommentar { get; set; }
	}
}
