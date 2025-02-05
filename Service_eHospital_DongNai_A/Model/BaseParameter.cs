namespace Service_eHospital_DongNai_A.Model
{
	public partial class BaseParameter : BaseModel
	{      
        public int? Page { get; set; }
		public int? PageSize { get; set; }              
		public string? SearchString { get; set; }				
		public DateTime? BatDau { get; set; }
		public DateTime? KetThuc { get; set; }
        public int? BenhAn_Id { get; set; }
        public int? PhongBan_Id { get; set; }
        public DateTime? NgayVaoVien { get; set; }
        public BaseParameter()
		{
		}
	}
}
