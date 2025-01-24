namespace Data_eHospital_DongNai_A.Model
{
    public partial class CDT_NhanSuTuyenDuoi : BaseModel
    {
        [Key]
        public int? NhanVien_Id { get; set; }
public int? BenhVien_Id { get; set; }
public string? MaNhanVien { get; set; }
public string? Ho { get; set; }
public string? Ten { get; set; }
public string? TenNhanVien { get; set; }
public string? TenNhanVien_Ru { get; set; }
public string? TenNhanVien_En { get; set; }
public string? TenTat { get; set; }
public DateTime? NgaySinh { get; set; }
public int? NamSinh { get; set; }
public string? GioiTinh { get; set; }
public string? DiaChi { get; set; }
public int? PhongBan_Id { get; set; }
public int? DonViCongTac_Id { get; set; }
public int? ChucDanh_Id { get; set; }
public int? ChucVu_Id { get; set; }
public int? TrinhDoChuyenMon_Id { get; set; }
public int? QuocTich_Id { get; set; }
public int? TinhThanh_Id { get; set; }
public int? QuanHuyen_Id { get; set; }
public int? XaPhuong_Id { get; set; }
public int? DanToc_Id { get; set; }
public int? NgheNhiep_Id { get; set; }
public string? CMND { get; set; }
public string? HoChieu { get; set; }
public bool? TrucTiepSX { get; set; }
public bool? TiepXucDocHai { get; set; }
public bool? TamNgung { get; set; }
public string? TenKhongDau { get; set; }
public DateTime? NgayTao { get; set; }
public int? NguoiTao_Id { get; set; }
public DateTime? NgayCapNhat { get; set; }
public int? NguoiCapNhat_Id { get; set; }
public string? MaDonVi { get; set; }
public DateTime? NgayVao { get; set; }
public string? MaNhanVienNSTL { get; set; }
public string? SoDienThoai { get; set; }
public string? Email { get; set; }

        public CDT_NhanSuTuyenDuoi()
        {
        }
    }
}

