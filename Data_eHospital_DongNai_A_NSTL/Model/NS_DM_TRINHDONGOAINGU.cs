namespace Data_eHospital_DongNai_A_NSTL.Model
{
    public partial class NS_DM_TRINHDONGOAINGU : BaseModel
    {
        [Key]
        public string? MaTDNgoaiNgu { get; set; }
public string? TenNgoaiNgu { get; set; }

        public NS_DM_TRINHDONGOAINGU()
        {
        }
    }
}

