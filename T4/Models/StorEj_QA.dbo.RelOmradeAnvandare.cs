// This class was automatically generated with love by ST4bby 2013-05-01 20:47:39.
// Read more at http://jbubriski.github.com/ST4bby/

namespace MySt4bbyNamespace
{
	using System;
	using System.ComponentModel.DataAnnotations;
	
	public class RelOmradeAnvandare
	{
		[Key, Required, Display(Name="ID")]
		public int ID { get; set; }
		
		[Required, Display(Name="Anvandare Id")]
		public int AnvandareId { get; set; }
		
		[Required, Display(Name="Omrade Id")]
		public int OmradeId { get; set; }
	}
}