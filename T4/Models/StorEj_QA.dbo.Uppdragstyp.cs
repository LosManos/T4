// This class was automatically generated with love by ST4bby 2013-05-03 17:53:43.
// Read more at http://jbubriski.github.com/ST4bby/

namespace MySt4bbyNamespace
{
	using System;
	using System.ComponentModel.DataAnnotations;
	
	public class Uppdragstyp
	{
		[Key, Required, Display(Name="Uppdragstyp ID")]
		public int UppdragstypID { get; set; }
		
		[Required, Display(Name="Titel")]
		public string Titel { get; set; }
	}
}
