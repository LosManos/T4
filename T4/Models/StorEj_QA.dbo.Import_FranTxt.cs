// This class was automatically generated with love by ST4bby 2013-05-03 17:53:43.
// Read more at http://jbubriski.github.com/ST4bby/

namespace MySt4bbyNamespace
{
	using System;
	using System.ComponentModel.DataAnnotations;
	
	public class Import_FranTxt
	{
		[Key, Required, Display(Name="Import ID")]
		public int ImportID { get; set; }
		
		[Required, Display(Name="Batch ID")]
		public int BatchID { get; set; }
		
		[Required, Display(Name="Bostadsbolag")]
		public string Bostadsbolag { get; set; }
		
		[Required, Display(Name="Lokaltyp")]
		public string Lokaltyp { get; set; }
		
		[Required, Display(Name="Kontraktsnummer")]
		public string Kontraktsnummer { get; set; }
		
		[Required, Display(Name="Namn")]
		public string Namn { get; set; }
		
		[Required, Display(Name="Adress")]
		public string Adress { get; set; }
		
		[Required, Display(Name="Vaning")]
		public string Vaning { get; set; }
		
		[Required, Display(Name="Tel")]
		public string Tel { get; set; }
		
		[Required, Display(Name="Fodelsear")]
		public string Fodelsear { get; set; }
		
		[Required, Display(Name="Omrade")]
		public string Omrade { get; set; }
		
		[Required, Display(Name="Namn Andrahandshyresgast")]
		public string NamnAndrahandshyresgast { get; set; }
		
		[Required, Display(Name="Namn Nyttjare")]
		public string NamnNyttjare { get; set; }
		
		[Required, Display(Name="Tel Andrahandshyresgast")]
		public string TelAndrahandshyresgast { get; set; }
		
		[Required, Display(Name="Adress Tillagg")]
		public string AdressTillagg { get; set; }
		
		[Required, Display(Name="Portkod")]
		public string Portkod { get; set; }
	}
}
