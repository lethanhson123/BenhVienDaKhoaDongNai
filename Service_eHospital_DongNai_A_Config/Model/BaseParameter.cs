namespace Service_eHospital_DongNai_A_Config.Model
{
	public partial class BaseParameter : BaseModel
	{      
        public int? Page { get; set; }
		public int? PageSize { get; set; }              
		public string? SearchString { get; set; }				
		public DateTime? BatDau { get; set; }
		public DateTime? KetThuc { get; set; }
        public int? User_Id { get; set; }
        public string? Code { get; set; }
        public BaseParameter()
		{
		}
	}
}
