namespace Data_eHospital_DongNai_A_Dictionary.Model
{
    public partial class DM_NhomDichVu : BaseModel
    {
        [Key]
        public int? NhomDichVu_Id { get; set; }
public string? MaNhomDichVu { get; set; }
public int? LoaiDichVu_Id { get; set; }
public string? TenNhomDichVu { get; set; }
public string? TenNhomDichVu_En { get; set; }
public string? TenNhomDichVu_Ru { get; set; }
public int? Cap { get; set; }
public int? CapTren_Id { get; set; }
public bool? TraLoiKetQuaRieng { get; set; }
public bool? TamNgung { get; set; }
public string? TenKhongDau { get; set; }
public DateTime? NgayTao { get; set; }
public int? NguoiTao_Id { get; set; }
public DateTime? NgayCapNhat { get; set; }
public int? NguoiCapNhat_Id { get; set; }
public bool? DuocCapSTT { get; set; }
public string? SiteCode { get; set; }
public int? Mapping_Public_Id { get; set; }
public bool? CapSoTT { get; set; }
public bool? CreateSIDForPACS { get; set; }

        public DM_NhomDichVu()
        {
        }
    }
}

