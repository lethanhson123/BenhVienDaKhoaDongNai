namespace Data_eHospital_DongNai_A.Model
{
    public partial class ztmp_BCVP_064D : BaseModel
    {
        [Key]
        public string? SoHoaDonVAT { get; set; }
public string? TenBenhNhan { get; set; }
public string? SoVaoVien { get; set; }
public DateTime? NgayHoaDon { get; set; }
public decimal? GiaTriHoaDon { get; set; }
public decimal? GiaTriHuy { get; set; }
public decimal? GiaTriHoanTra { get; set; }
public string? GhiChu { get; set; }
public bool? HuyHoaDon { get; set; }
public bool? HoanTra { get; set; }
public string? Loai { get; set; }
public string? nhanvienthutien { get; set; }
public DateTime? Date01 { get; set; }
public DateTime? Date02 { get; set; }
public string? NguoiThuTien { get; set; }

        public ztmp_BCVP_064D()
        {
        }
    }
}

