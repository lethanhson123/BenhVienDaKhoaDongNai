namespace Data_eHospital_DongNai_A.Model
{
    public partial class CSKH_DM_GoiDichVu : BaseModel
    {
        [Key]
        public int? GoiDichVu_Id { get; set; }
public string? MaGoiDichVu { get; set; }
public string? TenGoiDicVu { get; set; }
public string? TenGoiDicVu_EN { get; set; }
public string? TenGoiDicVu_RU { get; set; }
public decimal? SoTienThucThu { get; set; }
public decimal? SoTienGoiKham { get; set; }
public string? TienTe_Id { get; set; }
public string? TyGia { get; set; }
public DateTime? NgayHieuLuc { get; set; }
public DateTime? NgayHetHan { get; set; }
public int? Idx { get; set; }
public string? GhiChu { get; set; }
public bool? TamNgung { get; set; }
public DateTime? NgayTao { get; set; }
public int? NguoiTao_Id { get; set; }
public DateTime? NgayCapNhat { get; set; }
public int? NguoiCapNhat_Id { get; set; }
public decimal? Attribute1 { get; set; }
public decimal? Attribute2 { get; set; }
public int? Attribute3 { get; set; }
public string? Attribute4 { get; set; }
public DateTime? Attribute5 { get; set; }
public bool? GoiKhamSucKhoe { get; set; }
public int? ChuyenKhoa_Id { get; set; }
public int? Nam { get; set; }
public int? Thang { get; set; }
public int? Ngay { get; set; }
public int? CostCenter_Id { get; set; }
public int? SoNgayFU { get; set; }
public bool? KiemTraDieuKienKhoaGoi { get; set; }
public string? CheckList { get; set; }

        public CSKH_DM_GoiDichVu()
        {
        }
    }
}

