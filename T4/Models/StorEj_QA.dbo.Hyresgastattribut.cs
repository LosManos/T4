// This class was automatically generated with love by ST4bby 2013-05-03 17:53:43.
// Read more at http://jbubriski.github.com/ST4bby/

namespace MySt4bbyNamespace
{
	using System;
	using System.ComponentModel.DataAnnotations;
	
	public class Hyresgastattribut
	{
		[Key, Required, Display(Name="Hyresgastattribut ID")]
		public int HyresgastattributID { get; set; }
		
		[Required, Display(Name="Portkod"), StringLength(100)]
		public string Portkod { get; set; }
	}
}
