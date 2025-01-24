namespace Data_eHospital_DongNai_A.Model
{
    public partial class zzz_DM_Duoc_20210922 : BaseModel
    {
        [Key]
        public int? Duoc_id { get; set; }
public string? MaDuoc { get; set; }
public string? TenHang { get; set; }
public string? TenDuocDayDu { get; set; }
public string? TenDuocDayDu_KhongDau { get; set; }

        public zzz_DM_Duoc_20210922()
        {
        }
    }
}

