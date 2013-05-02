// This class was automatically generated with love by ST4bby 2013-05-01 20:47:40.
// Read more at http://jbubriski.github.com/ST4bby/

namespace MySt4bbyNamespace
{
	using System;
	using System.ComponentModel.DataAnnotations;
	
	public class Arendelogg
	{
		[Key, Required, Display(Name="Arendelogg ID")]
		public int ArendeloggID { get; set; }
		
		[Required, Display(Name="Arende ID")]
		public int ArendeID { get; set; }
		
		[Required, Display(Name="Anvandare ID")]
		public int AnvandareID { get; set; }
		
		[Required, Display(Name="Datumtid")]
		public DateTime Datumtid { get; set; }
		
		[Required, Display(Name="Meddelande")]
		public string Meddelande { get; set; }
		
		[Required, Display(Name="Anvandare _ Anvandarnamn")]
		public string Anvandare_Anvandarnamn { get; set; }
		
		[Required, Display(Name="Anvandare _ Namn")]
		public string Anvandare_Namn { get; set; }
	}
}
