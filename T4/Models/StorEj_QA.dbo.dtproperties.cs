// This class was automatically generated with love by ST4bby 2013-05-01 20:47:40.
// Read more at http://jbubriski.github.com/ST4bby/

namespace MySt4bbyNamespace
{
	using System;
	using System.ComponentModel.DataAnnotations;
	
	public class dtproperties
	{
		[Key, Required, Display(Name="id")]
		public int id { get; set; }
		
		[Display(Name="objectid")]
		public Nullable<int> objectid { get; set; }
		
		[Required, Display(Name="property"), StringLength(64)]
		public string property { get; set; }
		
		[Display(Name="value"), StringLength(255)]
		public string value { get; set; }
		
		[Display(Name="uvalue"), StringLength(510)]
		public string uvalue { get; set; }
		
		[Display(Name="lvalue")]
		public string lvalue { get; set; }
		
		[Required, Display(Name="version")]
		public int version { get; set; }
	}
}
