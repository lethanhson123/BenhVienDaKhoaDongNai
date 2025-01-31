namespace Data_eHospital_DongNai_A_Dictionary.Model
{
    public partial class DM_ICD_Chuong : BaseModel
    {
        [Key]
        public int? ICD_Chuong_Id { get; set; }
public string? MaChuongICD { get; set; }
public string? TenChuongICD { get; set; }
public string? TenChuongICD_En { get; set; }
public string? TenChuongICD_Ru { get; set; }
public bool? TamNgung { get; set; }
public string? TenKhongDau { get; set; }
public DateTime? NgayTao { get; set; }
public int? NguoiTao_Id { get; set; }
public DateTime? NgayCapNhat { get; set; }
public int? NguoiCapNhat_Id { get; set; }

        public DM_ICD_Chuong()
        {
        }
    }
}

