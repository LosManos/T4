// This class was automatically generated with love by ST4bby 2013-05-01 20:47:40.
// Read more at http://jbubriski.github.com/ST4bby/

namespace MySt4bbyNamespace
{
	using System;
	using System.ComponentModel.DataAnnotations;
	
	public class Arende
	{
		[Key, Required, Display(Name="Arende ID")]
		public int ArendeID { get; set; }
		
		[Display(Name="Delegerat Till Grupp ID")]
		public Nullable<int> DelegeratTillGruppID { get; set; }
		
		[Required, Display(Name="Arendestatus ID")]
		public int ArendestatusID { get; set; }
		
		[Required, Display(Name="Fakturerande Bolag ID")]
		public int FakturerandeBolagID { get; set; }
		
		[Required, Display(Name="Uppdragstyp ID")]
		public int UppdragstypID { get; set; }
		
		[Required, Display(Name="Iakttagelser")]
		public string Iakttagelser { get; set; }
		
		[Required, Display(Name="Tidloggkommentar")]
		public string Tidloggkommentar { get; set; }
		
		[Display(Name="Last Av Anvandare ID")]
		public Nullable<int> LastAvAnvandareID { get; set; }
		
		[Display(Name="Last Datum Tid")]
		public Nullable<DateTime> LastDatumTid { get; set; }
		
		[Display(Name="Signerat Av")]
		public string SigneratAv { get; set; }
		
		[Required, Display(Name="Skapat Anvandare ID")]
		public int SkapatAnvandareID { get; set; }
		
		[Required, Display(Name="Skapat Datumtid")]
		public DateTime SkapatDatumtid { get; set; }
		
		[Display(Name="Redigerat Anvandare ID")]
		public Nullable<int> RedigeratAnvandareID { get; set; }
		
		[Display(Name="Redigerat Datumtid")]
		public Nullable<DateTime> RedigeratDatumtid { get; set; }
		
		[Required, Display(Name="Prio")]
		public int Prio { get; set; }
	}
}
