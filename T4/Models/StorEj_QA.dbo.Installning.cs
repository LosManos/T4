// This class was automatically generated with love by ST4bby 2013-05-01 20:47:40.
// Read more at http://jbubriski.github.com/ST4bby/

namespace MySt4bbyNamespace
{
	using System;
	using System.ComponentModel.DataAnnotations;
	
	public class Installning
	{
		[Required, Display(Name="Installning ID")]
		public int InstallningID { get; set; }
		
		[Required, Display(Name="Installning Nyckel")]
		public string InstallningNyckel { get; set; }
		
		[Required, Display(Name="Datatyp ID")]
		public int DatatypID { get; set; }
		
		[Required, Display(Name="Titel"), StringLength(200)]
		public string Titel { get; set; }
		
		[Required, Display(Name="Varde")]
		public string Varde { get; set; }
		
		[Required, Display(Name="Kommentar")]
		public string Kommentar { get; set; }
	}
}
