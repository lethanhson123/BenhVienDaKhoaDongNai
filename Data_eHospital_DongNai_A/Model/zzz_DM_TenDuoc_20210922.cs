namespace Data_eHospital_DongNai_A.Model
{
    public partial class zzz_DM_TenDuoc_20210922 : BaseModel
    {
        [Key]
        public int? TenDuoc_id { get; set; }
public string? MaTenDuoc { get; set; }
public string? TenDuoc { get; set; }
public string? TenKhongDau { get; set; }

        public zzz_DM_TenDuoc_20210922()
        {
        }
    }
}

