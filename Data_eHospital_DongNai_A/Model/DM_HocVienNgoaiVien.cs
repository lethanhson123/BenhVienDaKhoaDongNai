namespace Data_eHospital_DongNai_A.Model
{
    public partial class DM_HocVienNgoaiVien : BaseModel
    {
        [Key]
        public int? HocVien_Id { get; set; }
public string? MaHocVien { get; set; }
public string? Ho { get; set; }
public string? Ten { get; set; }
public string? TenHocVien { get; set; }
public string? TenHocVien_Ru { get; set; }
public string? TenHocVien_En { get; set; }
public string? TenTat { get; set; }
public DateTime? NgaySinh { get; set; }
public string? GioiTinh { get; set; }
public string? DiaChi { get; set; }
public int? QuocTich_Id { get; set; }
public int? TinhThanh_Id { get; set; }
public int? QuanHuyen_Id { get; set; }
public int? XaPhuong_Id { get; set; }
public int? DanToc_Id { get; set; }
public int? NgheNhiep_Id { get; set; }
public string? CMND { get; set; }
public string? HoChieu { get; set; }
public bool? TamNgung { get; set; }
public string? TenKhongDau { get; set; }
public DateTime? NgayTao { get; set; }
public int? NguoiTao_Id { get; set; }
public DateTime? NgayCapNhat { get; set; }
public int? NguoiCapNhat_Id { get; set; }
public string? SoDienThoai { get; set; }
public string? Email { get; set; }
public int? PhongBan_ID { get; set; }
public int? ChucDanh_ID { get; set; }
public int? ChucVu_ID { get; set; }

        public DM_HocVienNgoaiVien()
        {
        }
    }
}

