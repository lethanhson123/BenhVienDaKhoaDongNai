namespace Data_eHospital_DongNai_A.Model
{
    public partial class DM_ICD_Nhom_tmp : BaseModel
    {
        [Key]
        public int? ICD_Nhom_Id { get; set; }
public string? MaNhomICD { get; set; }
public string? TenNhomICD { get; set; }
public string? TenNhomICD_En { get; set; }
public string? TenNhomICD_Ru { get; set; }
public int? ICD_Chuong_Id { get; set; }
public bool? TamNgung { get; set; }
public string? TenKhongDau { get; set; }
public DateTime? NgayTao { get; set; }
public int? NguoiTao_Id { get; set; }
public DateTime? NgayCapNhat { get; set; }
public int? NguoiCapNhat_Id { get; set; }
public string? Ma_Chuong { get; set; }

        public DM_ICD_Nhom_tmp()
        {
        }
    }
}

