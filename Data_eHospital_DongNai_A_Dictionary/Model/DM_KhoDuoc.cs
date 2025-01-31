namespace Data_eHospital_DongNai_A_Dictionary.Model
{
    public partial class DM_KhoDuoc : BaseModel
    {
        [Key]
        public int? KhoDuoc_Id { get; set; }
public string? MaKho { get; set; }
public string? TenKho { get; set; }
public int? PhongBan_Id { get; set; }
public int? LoaiKho_Id { get; set; }
public bool? TamNgung { get; set; }
public string? TenKhongDau { get; set; }
public DateTime? NgayTao { get; set; }
public int? NguoiTao_Id { get; set; }
public DateTime? NgayCapNhat { get; set; }
public int? NguoiCapNhat_Id { get; set; }
public bool? QLNguon { get; set; }
public bool? KhoDuoc { get; set; }
public bool? KhoTaiSan { get; set; }
public bool? KhoNHM { get; set; }
public bool? KhoVPP { get; set; }
public bool? KhoTTB { get; set; }
public int? ChuyenKhoa_Id { get; set; }
public int? CostCenter_Id { get; set; }
public string? SiteCode { get; set; }
public int? Mapping_Public_Id { get; set; }

        public DM_KhoDuoc()
        {
        }
    }
}

