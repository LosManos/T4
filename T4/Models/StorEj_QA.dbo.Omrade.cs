// This class was automatically generated with love by ST4bby 2013-05-03 17:53:43.
// Read more at http://jbubriski.github.com/ST4bby/

namespace MySt4bbyNamespace
{
	using System;
	using System.ComponentModel.DataAnnotations;
	
	public class Omrade
	{
		[Key, Required, Display(Name="Omrade ID")]
		public int OmradeID { get; set; }
		
		[Required, Display(Name="Distrikt ID")]
		public int DistriktID { get; set; }
		
		[Required, Display(Name="Titel")]
		public string Titel { get; set; }
	}
}
