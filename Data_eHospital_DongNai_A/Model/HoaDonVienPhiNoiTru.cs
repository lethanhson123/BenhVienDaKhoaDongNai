namespace Data_eHospital_DongNai_A.Model
{
    public partial class HoaDonVienPhiNoiTru : BaseModel
    {
        [Key]
        public int? HoaDonNoiTru_Id { get; set; }
public int? HoaDon_Id { get; set; }
public int? CLSYeuCauChiTiet_Id { get; set; }
public int? NoiTru_DichVu_Id { get; set; }
public int? NoiTru_ToaThuoc_Id { get; set; }
public int? NoiTru_TraThuoc_Id { get; set; }
public int? BenhAnPhauThuat_VTYT_Id { get; set; }
public int? NoiTru_GiuongBenh_Id { get; set; }
public int? PhongBan_Id { get; set; }
public DateTime? NgayThu { get; set; }
public DateTime? ThoiGianThu { get; set; }
public decimal? DonGiaDoanhThu { get; set; }
public decimal? DonGiaThanhToan { get; set; }
public string? TyGia { get; set; }
public string? SoLuong { get; set; }
public string? SoTien { get; set; }
public string? DienGiai { get; set; }
public int? NguoiTao_Id { get; set; }
public DateTime? NgayTao { get; set; }
public int? NguoiCapNhat_Id { get; set; }
public DateTime? NgayCapNhat { get; set; }
public int? LyDoMienGiam_Id { get; set; }
public string? TyLeMienGiam { get; set; }
public string? SoTienMienGiam { get; set; }
public string? SoTienThatThu { get; set; }

        public HoaDonVienPhiNoiTru()
        {
        }
    }
}

