namespace Service_eHospital_DongNai_A.Model
{
	public partial class BaseParameter : Data_eHospital_DongNai_A.Model.BaseModel
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
        public List<int?> ListID { get; set; }
        public int? ID { get; set; }
        public int? BenhNhan_Id { get; set; }
        public int? BenhAn_Id { get; set; }
        public int? TiepNhan_Id { get; set; }
        public int? PhongBan_Id { get; set; }
        public int? KhamBenh_Id { get; set; }
        public int? KhamBenhVaoVien_Id { get; set; }
        public int? KhamBenh_ToaThuoc_Id { get; set; }
        public int? ChungTu_Id { get; set; }
        public int? NhomDichVu_Id { get; set; }
        public DateTime? NgayVaoVien { get; set; }
        public DateTime? NgayTiepNhan { get; set; }
        public DateTime? NgayKham { get; set; }
        public DateTime? NgayToaThuoc { get; set; }
        public DateTime? NgayChungTu { get; set; }      
        public BaseParameter()
		{
		}
	}
}
