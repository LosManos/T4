// This class was automatically generated with love by ST4bby 2013-05-03 17:53:44.
// Read more at http://jbubriski.github.com/ST4bby/

namespace MySt4bbyNamespace
{
	using System;
	using System.ComponentModel.DataAnnotations;
	
	public class Tillsynsarende
	{
		[Key, Required, Display(Name="Tillsynsarende ID")]
		public int TillsynsarendeID { get; set; }
		
		[Required, Display(Name="Arende ID")]
		public int ArendeID { get; set; }
		
		[Required, Display(Name="Bestallning ID")]
		public int BestallningID { get; set; }
		
		[Display(Name="Tillsynsplanering ID")]
		public Nullable<int> TillsynsplaneringID { get; set; }
		
		[Required, Display(Name="Planerat Utforande Start")]
		public DateTime PlaneratUtforandeStart { get; set; }
		
		[Required, Display(Name="Planerat Utforande Slut")]
		public DateTime PlaneratUtforandeSlut { get; set; }
		
		[Required, Display(Name="Omplanering Tillaten")]
		public bool OmplaneringTillaten { get; set; }
		
		[Required, Display(Name="Dag")]
		public bool Dag { get; set; }
	}
}
