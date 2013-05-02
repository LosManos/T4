// This class was automatically generated with love by ST4bby 2013-05-01 20:47:39.
// Read more at http://jbubriski.github.com/ST4bby/

namespace MySt4bbyNamespace
{
	using System;
	using System.ComponentModel.DataAnnotations;
	
	public class Alarm
	{
		[Key, Required, Display(Name="Alarm ID")]
		public int AlarmID { get; set; }
		
		[Required, Display(Name="Arende ID")]
		public int ArendeID { get; set; }
		
		[Required, Display(Name="Grupp ID")]
		public int GruppID { get; set; }
		
		[Required, Display(Name="Start")]
		public DateTime Start { get; set; }
		
		[Required, Display(Name="Stopp")]
		public DateTime Stopp { get; set; }
		
		[Display(Name="Signalerat Tid")]
		public Nullable<DateTime> SignaleratTid { get; set; }
	}
}
