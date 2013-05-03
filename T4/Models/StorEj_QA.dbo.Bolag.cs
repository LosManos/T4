// This class was automatically generated with love by ST4bby 2013-05-03 17:53:43.
// Read more at http://jbubriski.github.com/ST4bby/

namespace MySt4bbyNamespace
{
	using System;
	using System.ComponentModel.DataAnnotations;
	
	public class Bolag
	{
		[Key, Required, Display(Name="Bolag ID")]
		public int BolagID { get; set; }
		
		[Required, Display(Name="Forkortning")]
		public string Forkortning { get; set; }
		
		[Required, Display(Name="Namn")]
		public string Namn { get; set; }
		
		[Display(Name="Matcha Namn Vid Import")]
		public Nullable<bool> MatchaNamnVidImport { get; set; }
		
		[Required, Display(Name="Offentlig")]
		public bool Offentlig { get; set; }
	}
}
