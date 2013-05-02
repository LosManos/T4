// This class was automatically generated with love by ST4bby 2013-05-01 20:47:41.
// Read more at http://jbubriski.github.com/ST4bby/

namespace MySt4bbyNamespace
{
	using System;
	using System.ComponentModel.DataAnnotations;
	
	public class Distrikt
	{
		[Key, Required, Display(Name="Distrikt ID")]
		public int DistriktID { get; set; }
		
		[Required, Display(Name="Bolag ID")]
		public int BolagID { get; set; }
		
		[Required, Display(Name="Titel")]
		public string Titel { get; set; }
	}
}
