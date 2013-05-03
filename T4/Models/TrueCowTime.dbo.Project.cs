// This class was automatically generated with love by ST4bby 2013-05-03 18:12:04.
// Read more at http://jbubriski.github.com/ST4bby/

namespace MySt4bbyNamespace
{
	using System;
	using System.ComponentModel.DataAnnotations;
	
	public class Project
	{
		[Key, Required, Display(Name="Project ID")]
		public int ProjectID { get; set; }
		
		[Display(Name="Parent Project ID")]
		public Nullable<int> ParentProjectID { get; set; }
		
		[Required, Display(Name="Name"), StringLength(50)]
		public string Name { get; set; }
	}
}
