namespace Data_eHospital_DongNai_A.Model
{
    public partial class CSKH_The_TangTien : BaseModel
    {
        [Key]
        public int? The_TangTien_Id { get; set; }
public int? The_Id { get; set; }
public int? LoaiKhachHang_Id { get; set; }
public decimal? SoTienDuocTang { get; set; }
public bool? DenKham { get; set; }
public decimal? TongTienLanKham { get; set; }
public int? SoLanKham { get; set; }
public decimal? TongTienThoiGian { get; set; }
public DateTime? ThoiGianMin { get; set; }
public DateTime? ThoiGianMax { get; set; }
public int? SoThangQD { get; set; }
public DateTime? NgayTao { get; set; }
public int? NguoiTao_Id { get; set; }
public DateTime? NgayCapNhat { get; set; }
public int? NguoiCapNhat_Id { get; set; }

        public CSKH_The_TangTien()
        {
        }
    }
}

