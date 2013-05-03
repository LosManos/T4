// This class was automatically generated with love by ST4bby 2013-05-03 17:53:43.
// Read more at http://jbubriski.github.com/ST4bby/

namespace MySt4bbyNamespace
{
	using System;
	using System.ComponentModel.DataAnnotations;
	
	public class RelRollAnvandare
	{
		[Key, Required, Display(Name="ID")]
		public int ID { get; set; }
		
		[Required, Display(Name="Roll ID")]
		public int RollID { get; set; }
		
		[Required, Display(Name="Anvandare ID")]
		public int AnvandareID { get; set; }
	}
}
