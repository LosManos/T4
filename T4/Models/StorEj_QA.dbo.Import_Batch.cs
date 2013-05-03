// This class was automatically generated with love by ST4bby 2013-05-03 17:53:43.
// Read more at http://jbubriski.github.com/ST4bby/

namespace MySt4bbyNamespace
{
	using System;
	using System.ComponentModel.DataAnnotations;
	
	public class Import_Batch
	{
		[Key, Required, Display(Name="Batch ID")]
		public int BatchID { get; set; }
		
		[Required, Display(Name="Anvandare ID")]
		public int AnvandareID { get; set; }
		
		[Required, Display(Name="Import Datum")]
		public DateTime ImportDatum { get; set; }
		
		[Required, Display(Name="Ar Importerad")]
		public bool ArImporterad { get; set; }
	}
}
