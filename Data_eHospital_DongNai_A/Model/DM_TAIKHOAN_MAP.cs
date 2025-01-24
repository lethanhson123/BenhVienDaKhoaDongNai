namespace Data_eHospital_DongNai_A.Model
{
    public partial class DM_TAIKHOAN_MAP : BaseModel
    {
        [Key]
        public string? MaDoiTuong { get; set; }
public string? Module { get; set; }
public string? TaiKhoanCo { get; set; }
public string? TaiKhoanNo { get; set; }
public string? DangSuDung { get; set; }
public string? DienGiai { get; set; }
public string? TKThueNo { get; set; }
public string? TKThueCo { get; set; }
public string? Nguon { get; set; }
public string? UserID { get; set; }
public string? GhiChu { get; set; }
public string? LoaiCT { get; set; }

        public DM_TAIKHOAN_MAP()
        {
        }
    }
}

