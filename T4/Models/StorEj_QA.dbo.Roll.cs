// This class was automatically generated with love by ST4bby 2013-05-01 20:47:40.
// Read more at http://jbubriski.github.com/ST4bby/

namespace MySt4bbyNamespace
{
	using System;
	using System.ComponentModel.DataAnnotations;
	
	public class Roll
	{
		[Required, Display(Name="Roll ID")]
		public int RollID { get; set; }
		
		[Required, Display(Name="Titel")]
		public string Titel { get; set; }
		
		[Required, Display(Name="Beskrivning"), StringLength(255)]
		public string Beskrivning { get; set; }
		
		[Required, Display(Name="Personal")]
		public bool Personal { get; set; }
		
		[Required, Display(Name="Ar System")]
		public bool ArSystem { get; set; }
	}
}
