namespace Data_eHospital_DongNai_A_NSTL.Model
{
    public partial class NS_DM_TONGIAO : BaseModel
    {
        [Key]
        public string? MaTonGiao { get; set; }
public string? TenTonGiao { get; set; }

        public NS_DM_TONGIAO()
        {
        }
    }
}

