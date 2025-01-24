namespace Data_eHospital_DongNai_A.Model
{
    public partial class DM_DichVu_201603 : BaseModel
    {
        [Key]
        public int? DichVu_Id { get; set; }
public int? NhomDichVu_Id { get; set; }
public string? MaDichVu { get; set; }
public string? MaDichVu_Seg01 { get; set; }
public string? MaDichVu_Seg02 { get; set; }
public string? MaDichVu_Seg03 { get; set; }
public string? MaDichVu_Seg04 { get; set; }
public string? TenDichVu { get; set; }
public string? TenDichVu_En { get; set; }
public string? TenDichVu_Ru { get; set; }
public int? Cap { get; set; }
public int? CapTren_Id { get; set; }
public string? DonViTinh { get; set; }
public int? Idx { get; set; }
public bool? ChonHetCapDuoi { get; set; }
public bool? CoGiaDichVu { get; set; }
public bool? GiaCoDinh { get; set; }
public bool? ThucHienBenNgoai { get; set; }
public string? SoPhim { get; set; }
public string? MaQuiDinh { get; set; }
public bool? TamNgung { get; set; }
public string? TenKhongDau { get; set; }
public DateTime? NgayTao { get; set; }
public int? NguoiTao_Id { get; set; }
public DateTime? NgayCapNhat { get; set; }
public int? NguoiCapNhat_Id { get; set; }
public bool? CoGiaTriChuan { get; set; }
public bool? Test { get; set; }
public string? Attribute1 { get; set; }
public string? Attribute2 { get; set; }
public string? Attribute3 { get; set; }
public string? Attribute4 { get; set; }
public string? Attribute5 { get; set; }
public int? NhomDichVu_Report_Local_Id { get; set; }
public int? NhomDichVu_Report_Global_Id { get; set; }
public string? ShortName { get; set; }
public string? InputCode { get; set; }
public bool? NoResult { get; set; }
public int? ApplyFor { get; set; }
public bool? PrintWhenNull { get; set; }
public string? ReportCode { get; set; }
public string? ReportTitle { get; set; }
public int? DoUuTienDichVu { get; set; }
public string? MaMay { get; set; }
public bool? BHYT { get; set; }
public bool? IsThongSo { get; set; }
public int? CostCenter_Id { get; set; }
public string? SiteCode { get; set; }
public int? Mapping_Public_Id { get; set; }

        public DM_DichVu_201603()
        {
        }
    }
}

