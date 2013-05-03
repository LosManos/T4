// This class was automatically generated with love by ST4bby 2013-05-03 17:53:43.
// Read more at http://jbubriski.github.com/ST4bby/

namespace MySt4bbyNamespace
{
	using System;
	using System.ComponentModel.DataAnnotations;
	
	public class Bestallning
	{
		[Key, Required, Display(Name="Bestallning ID")]
		public int BestallningID { get; set; }
		
		[Required, Display(Name="Bolag ID")]
		public int BolagID { get; set; }
		
		[Required, Display(Name="Referensperson ID")]
		public int ReferenspersonID { get; set; }
		
		[Required, Display(Name="Anvandare ID")]
		public int AnvandareID { get; set; }
		
		[Required, Display(Name="Beskrivning"), StringLength(2000)]
		public string Beskrivning { get; set; }
		
		[Required, Display(Name="Start")]
		public DateTime Start { get; set; }
		
		[Required, Display(Name="Slut")]
		public DateTime Slut { get; set; }
		
		[Required, Display(Name="Referensperson Namn"), StringLength(255)]
		public string ReferenspersonNamn { get; set; }
		
		[Required, Display(Name="Referensperson Telefonnummer"), StringLength(50)]
		public string ReferenspersonTelefonnummer { get; set; }
		
		[Required, Display(Name="Referensperson Kommentar"), StringLength(2000)]
		public string ReferenspersonKommentar { get; set; }
		
		[Required, Display(Name="Tillsynshyresgast Lagenhetsnummer"), StringLength(40)]
		public string TillsynshyresgastLagenhetsnummer { get; set; }
		
		[Required, Display(Name="Tillsynshyresgast Namn"), StringLength(255)]
		public string TillsynshyresgastNamn { get; set; }
		
		[Required, Display(Name="Tillsynshyresgast Adress"), StringLength(255)]
		public string TillsynshyresgastAdress { get; set; }
		
		[Required, Display(Name="Tillsynshyresgast Omrade")]
		public string TillsynshyresgastOmrade { get; set; }
		
		[Required, Display(Name="Tillsynshyresgast Portkod"), StringLength(10)]
		public string TillsynshyresgastPortkod { get; set; }
		
		[Required, Display(Name="Tillsynshyresgast Telefonnummer"), StringLength(50)]
		public string TillsynshyresgastTelefonnummer { get; set; }
		
		[Required, Display(Name="Tillsynshyresgast Kommentar"), StringLength(2000)]
		public string TillsynshyresgastKommentar { get; set; }
		
		[Display(Name="Tillsynshyresgast ID")]
		public Nullable<int> TillsynshyresgastID { get; set; }
		
		[Required, Display(Name="Kontakt Person ID")]
		public int KontaktPersonID { get; set; }
	}
}
