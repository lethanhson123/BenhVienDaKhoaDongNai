namespace Service.Model
{
	public partial class BaseParameter : BaseModel
	{
        public List<long>? ListID { get; set; }        
        public int? Page { get; set; }
		public int? PageSize { get; set; }       
        public int? Nam { get; set; }
        public int? Thang { get; set; }       
        public string? Password01 { get; set; }
		public string? Password02 { get; set; }
		public string? Password03 { get; set; }
		public string? TaiKhoan { get; set; }
		public string? SearchString { get; set; }
		public string? IDString { get; set; }
		public string? Token { get; set; }
		public DateTime? NgayGhiNhan { get; set; }
		public DateTime? BatDau { get; set; }
		public DateTime? KetThuc { get; set; }	
		public long? ThanhVienID { get; set; }       
        public string? QRCode { get; set; }
        public string? URL { get; set; }
        public string? SoQuyetDinh { get; set; }
        public BaseParameter()
		{
		}
	}
}
