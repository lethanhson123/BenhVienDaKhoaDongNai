namespace Service_eHospital_DongNai_A_System.Model
{
	public partial class BaseParameter : BaseModel
	{      
        public int? Page { get; set; }
		public int? PageSize { get; set; }              
		public string? SearchString { get; set; }				
		public DateTime? BatDau { get; set; }
		public DateTime? KetThuc { get; set; }
        public int? Menu_Level { get; set; }
        public int? Parent_Id { get; set; }
        public int? Group_Id { get; set; }
        public int? Menu_Id { get; set; }
        public int? User_Id { get; set; }
        public BaseParameter()
		{
		}
	}
}
