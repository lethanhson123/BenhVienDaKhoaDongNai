namespace Data_eHospital_DongNai_A.Model
{
    public partial class KhamBenh_HenTaiKham : BaseModel
    {
        [Key]
        public int? KhamBenh_Id { get; set; }
        public int? BenhNhan_Id { get; set; }
        public DateTime? NgayTaiKham { get; set; }
        public DateTime? ThoiGianTaiKham { get; set; }
        public DateTime? NgayTao { get; set; }
        public int? NguoiTao_Id { get; set; }
        public DateTime? NgayCapNhat { get; set; }
        public int? NguoiCapNhat_Id { get; set; }
        public bool? Loai { get; set; }
        public int? TiepNhan_Id { get; set; }
        public string? SoPhieuHen { get; set; }
        public int? STT { get; set; }

        public KhamBenh_HenTaiKham()
        {
        }
    }
}

