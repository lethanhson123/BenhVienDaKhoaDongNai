namespace Data_eHospital_DongNai_A.Model
{
    public partial class DM_KyThuat : BaseModel
    {
        [Key]
        public int? KyThuat_Id { get; set; }
public string? MaKyThuat { get; set; }
public string? TenKyThuat { get; set; }
public string? TenKyThuat_En { get; set; }
public string? TenKyThuat_Ru { get; set; }
public bool? TamNgung { get; set; }
public string? TenKhongDau { get; set; }
public DateTime? NgayTao { get; set; }
public int? NguoiTao_Id { get; set; }
public DateTime? NgayCapNhat { get; set; }
public int? NguoiCapNhat_Id { get; set; }

        public DM_KyThuat()
        {
        }
    }
}

