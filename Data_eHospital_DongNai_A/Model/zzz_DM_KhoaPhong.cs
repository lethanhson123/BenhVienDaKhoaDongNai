namespace Data_eHospital_DongNai_A.Model
{
    public partial class zzz_DM_KhoaPhong : BaseModel
    {
        [Key]
        public int? PhongBan_Id { get; set; }
public string? TenPhongBan { get; set; }
public string? TenPhongBan_En { get; set; }
public string? TenPhongBan_Ru { get; set; }
public string? Loai { get; set; }

        public zzz_DM_KhoaPhong()
        {
        }
    }
}

