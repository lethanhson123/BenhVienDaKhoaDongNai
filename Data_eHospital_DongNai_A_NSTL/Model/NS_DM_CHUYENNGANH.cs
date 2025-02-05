namespace Data_eHospital_DongNai_A_NSTL.Model
{
    public partial class NS_DM_CHUYENNGANH : BaseModel
    {
        [Key]
        public string? MaChuyenNganh { get; set; }
public string? TenChuyenNganh { get; set; }

        public NS_DM_CHUYENNGANH()
        {
        }
    }
}

