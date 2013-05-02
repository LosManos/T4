// This class was automatically generated with love by ST4bby 2013-05-01 20:47:40.
// Read more at http://jbubriski.github.com/ST4bby/

namespace MySt4bbyNamespace
{
	using System;
	using System.ComponentModel.DataAnnotations;
	
	public class AkutArende
	{
		[Key, Required, Display(Name="Akut Arende ID")]
		public int AkutArendeID { get; set; }
		
		[Required, Display(Name="Arende ID")]
		public int ArendeID { get; set; }
		
		[Required, Display(Name="Rapporterad Storningstyp ID")]
		public int RapporteradStorningstypID { get; set; }
		
		[Display(Name="Iakttagen Storningstyp ID")]
		public Nullable<int> IakttagenStorningstypID { get; set; }
		
		[Required, Display(Name="Beskrivning")]
		public string Beskrivning { get; set; }
		
		[Required, Display(Name="Anmalare _ Ej Kontakt")]
		public bool Anmalare_EjKontakt { get; set; }
		
		[Display(Name="Anmalare _ Hyresgast ID")]
		public Nullable<int> Anmalare_HyresgastID { get; set; }
		
		[Required, Display(Name="Anmalare _ Namn")]
		public string Anmalare_Namn { get; set; }
		
		[Required, Display(Name="Anmalare _ Gatuadress")]
		public string Anmalare_Gatuadress { get; set; }
		
		[Required, Display(Name="Anmalare _ Bor I Omrade ID")]
		public int Anmalare_BorIOmradeID { get; set; }
		
		[Required, Display(Name="Anmalare _ Bor I Omrade _ Titel")]
		public string Anmalare_BorIOmrade_Titel { get; set; }
		
		[Required, Display(Name="Anmalare _ Kontraktsnummer")]
		public string Anmalare_Kontraktsnummer { get; set; }
		
		[Required, Display(Name="Anmalare _ Tel")]
		public string Anmalare_Tel { get; set; }
		
		[Display(Name="Storande _ Hyresgast ID")]
		public Nullable<int> Storande_HyresgastID { get; set; }
		
		[Display(Name="Storande _ Namn")]
		public string Storande_Namn { get; set; }
		
		[Display(Name="Storande _ Gatuadress")]
		public string Storande_Gatuadress { get; set; }
		
		[Display(Name="Storande _ Bor I Omrade ID")]
		public Nullable<int> Storande_BorIOmradeID { get; set; }
		
		[Display(Name="Storande _ Bor I Omrade _ Titel")]
		public string Storande_BorIOmrade_Titel { get; set; }
		
		[Display(Name="Storande _ Kontraktsnummer")]
		public string Storande_Kontraktsnummer { get; set; }
		
		[Required, Display(Name="Storande _ Tel")]
		public string Storande_Tel { get; set; }
	}
}
