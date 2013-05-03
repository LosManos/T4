// conn string=Data Source=.\mssqlserver2012;Initial Catalog=TrueCowTime;Integrated Security=SSPI;

namespace MyAutomagicNamespace{

	public class Timeslot{
		public int TimeslotID{get;set;}
		public int ProjectID{get;set;}
		public datetime Date{get;set;}
		public datetime StartDatetime{get;set;}
		public datetime StopDatetime{get;set;}
		public int Duration{get;set;}
	}
	public class Project{
		public int ProjectID{get;set;}
		public int ParentProjectID{get;set;}
		public varchar Name{get;set;}
	}
}
