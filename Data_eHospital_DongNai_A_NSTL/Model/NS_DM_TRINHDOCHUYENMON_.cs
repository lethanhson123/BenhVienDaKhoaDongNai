namespace Data_eHospital_DongNai_A_NSTL.Model
{
    public partial class NS_DM_TRINHDOCHUYENMON_ : BaseModel
    {
        [Key]
        public string? MaTDChuyenMon { get; set; }
public string? TenTDChuyenMon { get; set; }

        public NS_DM_TRINHDOCHUYENMON_()
        {
        }
    }
}

