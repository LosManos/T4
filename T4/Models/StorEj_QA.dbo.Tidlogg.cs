// This class was automatically generated with love by ST4bby 2013-05-03 17:53:44.
// Read more at http://jbubriski.github.com/ST4bby/

namespace MySt4bbyNamespace
{
	using System;
	using System.ComponentModel.DataAnnotations;
	
	public class Tidlogg
	{
		[Key, Required, Display(Name="Tidlogg ID")]
		public int TidloggID { get; set; }
		
		[Required, Display(Name="Arende ID")]
		public int ArendeID { get; set; }
		
		[Display(Name="Arendestatus ID Fran")]
		public Nullable<int> ArendestatusIDFran { get; set; }
		
		[Required, Display(Name="Arendestatus ID Till")]
		public int ArendestatusIDTill { get; set; }
		
		[Required, Display(Name="Arendestatus Andrad")]
		public DateTime ArendestatusAndrad { get; set; }
		
		[Required, Display(Name="Arendestatus Andrad Original")]
		public DateTime ArendestatusAndradOriginal { get; set; }
		
		[Required, Display(Name="Andrande Anvandare ID")]
		public int AndrandeAnvandareID { get; set; }
		
		[Required, Display(Name="Skapat Anvandare ID")]
		public int SkapatAnvandareID { get; set; }
		
		[Required, Display(Name="Skapat Datumtid")]
		public DateTime SkapatDatumtid { get; set; }
		
		[Display(Name="Redigerat Anvandare ID")]
		public Nullable<int> RedigeratAnvandareID { get; set; }
		
		[Display(Name="Redigerat Datumtid")]
		public Nullable<DateTime> RedigeratDatumtid { get; set; }
	}
}
