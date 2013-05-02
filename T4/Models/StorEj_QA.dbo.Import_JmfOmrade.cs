// This class was automatically generated with love by ST4bby 2013-05-01 20:47:40.
// Read more at http://jbubriski.github.com/ST4bby/

namespace MySt4bbyNamespace
{
	using System;
	using System.ComponentModel.DataAnnotations;
	
	public class Import_JmfOmrade
	{
		[Key, Required, Display(Name="Jmf ID")]
		public int JmfID { get; set; }
		
		[Required, Display(Name="Omrade ID")]
		public int OmradeID { get; set; }
		
		[Required, Display(Name="Distrikt ID")]
		public int DistriktID { get; set; }
		
		[Required, Display(Name="Titel")]
		public string Titel { get; set; }
		
		[Required, Display(Name="Batch ID")]
		public int BatchID { get; set; }
		
		[Required, Display(Name="Hittad")]
		public bool Hittad { get; set; }
	}
}
