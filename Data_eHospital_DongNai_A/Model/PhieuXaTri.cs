namespace Data_eHospital_DongNai_A.Model
{
    public partial class PhieuXaTri : BaseModel
    {
        [Key]
        public int? PhieuXaTri_ID { get; set; }
public int? BenhAn_Id { get; set; }
public int? BenhNhan_ID { get; set; }
public DateTime? NgayXaTri { get; set; }
public int? TruongChieu_Id { get; set; }
public string? HuongDan { get; set; }
public string? Pha { get; set; }
public string? NangLuong { get; set; }
public string? DiemThamChieu { get; set; }
public string? TongLieu { get; set; }
public string? SoPhanLieu { get; set; }
public string? PhanLieu { get; set; }
public string? LichChieuXa { get; set; }
public int? BacSiXaTri_ID { get; set; }
public int? KyThuatVien_1 { get; set; }
public int? KyThuatVien_2 { get; set; }
public string? SSD { get; set; }
public string? GocThanMay { get; set; }
public string? GocCollimator { get; set; }
public string? GocNem { get; set; }
public string? DinhTuThe { get; set; }
public string? PhimKiemTra { get; set; }
public string? MU { get; set; }
public string? Chi { get; set; }
public string? GhiChu { get; set; }
public string? BachCau { get; set; }
public decimal? CanNang { get; set; }
public string? Hb { get; set; }
public string? MoPhong { get; set; }
public DateTime? NgayTao { get; set; }
public int? NguoiTao_ID { get; set; }
public DateTime? NgayCapNhat { get; set; }
public int? NguoiCapNhat_ID { get; set; }
public bool? TrangThai { get; set; }
public int? CLSYeuCau_ID { get; set; }

        public PhieuXaTri()
        {
        }
    }
}

