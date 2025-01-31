namespace Data_eHospital_DongNai_A_Dictionary.Model
{
    public partial class DM_ICD : BaseModel
    {
        [Key]
        public int? ICD_Id { get; set; }
public string? MaICD { get; set; }
public string? TenICD { get; set; }
public string? TenICD_En { get; set; }
public string? TenICD_Ru { get; set; }
public string? MucICD { get; set; }
public int? ICD_Nhom_Id { get; set; }
public string? PhanNhom { get; set; }
public short? Loai { get; set; }
public bool? BenhTruyenNhiem { get; set; }
public bool? TamNgung { get; set; }
public string? TenKhongDau { get; set; }
public DateTime? NgayTao { get; set; }
public int? NguoiTao_Id { get; set; }
public DateTime? NgayCapNhat { get; set; }
public int? NguoiCapNhat_Id { get; set; }
public int? Ma { get; set; }
public string? SiteCode { get; set; }
public int? Mapping_Public_Id { get; set; }

        public DM_ICD()
        {
        }
    }
}

