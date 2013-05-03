// This class was automatically generated with love by ST4bby 2013-05-03 17:53:43.
// Read more at http://jbubriski.github.com/ST4bby/

namespace MySt4bbyNamespace
{
	using System;
	using System.ComponentModel.DataAnnotations;
	
	public class Arendestatus
	{
		[Required, Display(Name="Arendestatus ID")]
		public int ArendestatusID { get; set; }
		
		[Required, Display(Name="Titel")]
		public string Titel { get; set; }
		
		[Required, Display(Name="Beskrivning")]
		public string Beskrivning { get; set; }
	}
}
