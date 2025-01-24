namespace Data_eHospital_DongNai_A.Model
{
    public partial class DM_ICD_tmp : BaseModel
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
public int? Loai { get; set; }
public bool? BenhTruyenNhiem { get; set; }
public bool? TamNgung { get; set; }
public string? TenKhongDau { get; set; }
public DateTime? NgayTao { get; set; }
public int? NguoiTao_Id { get; set; }
public DateTime? NgayCapNhat { get; set; }
public int? NguoiCapNhat_Id { get; set; }
public int? Ma { get; set; }
public string? Ma_Nhom { get; set; }

        public DM_ICD_tmp()
        {
        }
    }
}

