// This class was automatically generated with love by ST4bby 2013-05-03 17:53:44.
// Read more at http://jbubriski.github.com/ST4bby/

namespace MySt4bbyNamespace
{
	using System;
	using System.ComponentModel.DataAnnotations;
	
	public class Hyresgast
	{
		[Key, Required, Display(Name="Hyresgast ID")]
		public int HyresgastID { get; set; }
		
		[Display(Name="Hyresgastattribut ID")]
		public Nullable<int> HyresgastattributID { get; set; }
		
		[Required, Display(Name="Bor I Omrade ID")]
		public int BorIOmradeID { get; set; }
		
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
		
		[Required, Display(Name="Adresstillagg")]
		public string Adresstillagg { get; set; }
		
		[Required, Display(Name="Tel")]
		public string Tel { get; set; }
		
		[Required, Display(Name="Fodelsear")]
		public string Fodelsear { get; set; }
		
		[Required, Display(Name="Portkod")]
		public string Portkod { get; set; }
		
		[Required, Display(Name="Omrade")]
		public string Omrade { get; set; }
		
		[Required, Display(Name="Namn Andrahandshyresgast")]
		public string NamnAndrahandshyresgast { get; set; }
		
		[Required, Display(Name="Namn Nyttjare")]
		public string NamnNyttjare { get; set; }
		
		[Required, Display(Name="Tel Andrahandshyresgast")]
		public string TelAndrahandshyresgast { get; set; }
		
		[Required, Display(Name="Atgardskod")]
		public string Atgardskod { get; set; }
	}
}
