namespace Data_eHospital_DongNai_A.Model
{
    public partial class ztmp_BCQR_01 : BaseModel
    {
        [Key]
        public long? sTT { get; set; }
public string? soHoaDon { get; set; }
public string? soTaiKhoan { get; set; }
public string? soHoaDonQR { get; set; }
public decimal? giaTriHoaDon { get; set; }
public DateTime? thoiGianHoaDon { get; set; }
public string? LoaiThu { get; set; }
public string? soVaoVien { get; set; }
public string? maDotDieuTri { get; set; }
public string? tenBenhNhan { get; set; }
public int? namSinh { get; set; }
public string? soThamChieu { get; set; }
public string? maGiaoDich { get; set; }
public string? nguoiThu { get; set; }
public string? dienGiai { get; set; }

        public ztmp_BCQR_01()
        {
        }
    }
}

