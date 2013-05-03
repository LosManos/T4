// This class was automatically generated with love by ST4bby 2013-05-03 18:12:04.
// Read more at http://jbubriski.github.com/ST4bby/

namespace MySt4bbyNamespace
{
	using System;
	using System.ComponentModel.DataAnnotations;
	
	public class Timeslot
	{
		[Key, Required, Display(Name="Timeslot ID")]
		public int TimeslotID { get; set; }
		
		[Required, Display(Name="Project ID")]
		public int ProjectID { get; set; }
		
		[Display(Name="Date")]
		public Nullable<DateTime> Date { get; set; }
		
		[Display(Name="Start Datetime")]
		public Nullable<DateTime> StartDatetime { get; set; }
		
		[Display(Name="Stop Datetime")]
		public Nullable<DateTime> StopDatetime { get; set; }
		
		[Display(Name="Duration")]
		public Nullable<int> Duration { get; set; }
	}
}
