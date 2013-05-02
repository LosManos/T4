// This class was automatically generated with love by ST4bby 2013-05-01 20:47:40.
// Read more at http://jbubriski.github.com/ST4bby/

namespace MySt4bbyNamespace
{
	using System;
	using System.ComponentModel.DataAnnotations;
	
	public class Logg
	{
		[Key, Required, Display(Name="Logg ID")]
		public int LoggID { get; set; }
		
		[Required, Display(Name="Anvandare Namn"), StringLength(50)]
		public string AnvandareNamn { get; set; }
		
		[Required, Display(Name="Namn"), StringLength(50)]
		public string Namn { get; set; }
		
		[Required, Display(Name="Beskrivning"), StringLength(1000)]
		public string Beskrivning { get; set; }
		
		[Required, Display(Name="Data"), StringLength(1000)]
		public string Data { get; set; }
		
		[Required, Display(Name="Kommentar"), StringLength(1000)]
		public string Kommentar { get; set; }
		
		[Required, Display(Name="Skapad")]
		public DateTime Skapad { get; set; }
	}
}
