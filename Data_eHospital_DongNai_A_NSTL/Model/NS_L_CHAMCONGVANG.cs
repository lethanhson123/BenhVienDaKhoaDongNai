namespace Data_eHospital_DongNai_A_NSTL.Model
{
    public partial class NS_L_CHAMCONGVANG : BaseModel
    {
        [Key]
        public int? ID { get; set; }
public string? MaNhanVien { get; set; }
public DateTime? NgayNghi { get; set; }
public string? Malydovangmat { get; set; }
public float? SoGioVang { get; set; }
public float? TyLeHuongLuong { get; set; }
public string? MaPhongBan { get; set; }
public string? Malydovangmat2 { get; set; }
public string? Malydovangmat3 { get; set; }
public string? Malydovangmat4 { get; set; }
public bool? Khoa { get; set; }
public DateTime? GioBatDau_LD2 { get; set; }
public DateTime? GioKetThuc_LD2 { get; set; }
public decimal? SoGioLyDo2 { get; set; }
public string? GhiChuLD2 { get; set; }
public DateTime? GioBatDau_LD3 { get; set; }
public DateTime? GioKetThuc_LD3 { get; set; }
public decimal? SoGioLyDo3 { get; set; }
public string? GhiChuLD3 { get; set; }
public bool? Khoa_LamThem { get; set; }
public string? MaTrai { get; set; }

        public NS_L_CHAMCONGVANG()
        {
        }
    }
}

