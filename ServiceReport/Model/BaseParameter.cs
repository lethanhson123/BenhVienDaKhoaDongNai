namespace ServiceReport.Model
{
	public partial class BaseParameter : ServiceReport.Model.BaseModel
    {      
        public int? Page { get; set; }
		public int? PageSize { get; set; }              
		public string? SearchString { get; set; }				
		public DateTime? BatDau { get; set; }
		public DateTime? KetThuc { get; set; }
        public int? Year { get; set; }
        public int? Month { get; set; }
        public int? Day { get; set; }
        public List<string>? ListIDString { get; set; }
        public int? ID { get; set; }
        public int? PhongBanID { get; set; }
        public BaseParameter()
		{
		}
	}
}
