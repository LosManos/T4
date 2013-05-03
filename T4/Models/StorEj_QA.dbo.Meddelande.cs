// This class was automatically generated with love by ST4bby 2013-05-03 17:53:43.
// Read more at http://jbubriski.github.com/ST4bby/

namespace MySt4bbyNamespace
{
	using System;
	using System.ComponentModel.DataAnnotations;
	
	public class Meddelande
	{
		[Key, Required, Display(Name="Meddelande ID")]
		public int MeddelandeID { get; set; }
		
		[Required, Display(Name="Datum Tid")]
		public DateTime DatumTid { get; set; }
		
		[Display(Name="Arende ID")]
		public Nullable<int> ArendeID { get; set; }
		
		[Required, Display(Name="Sandare _ Anvandare ID")]
		public int Sandare_AnvandareID { get; set; }
		
		[Display(Name="Sandare _ Grupp ID")]
		public Nullable<int> Sandare_GruppID { get; set; }
		
		[Required, Display(Name="Sandare _ Roll ID")]
		public int Sandare_RollID { get; set; }
		
		[Display(Name="Mottagare _ Grupp ID")]
		public Nullable<int> Mottagare_GruppID { get; set; }
		
		[Display(Name="Mottagare _ Roll ID")]
		public Nullable<int> Mottagare_RollID { get; set; }
		
		[Required, Display(Name="Meddelande")]
		public string Meddelande { get; set; }
	}
}
