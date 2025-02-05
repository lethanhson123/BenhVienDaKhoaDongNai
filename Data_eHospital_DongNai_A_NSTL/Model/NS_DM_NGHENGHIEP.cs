namespace Data_eHospital_DongNai_A_NSTL.Model
{
    public partial class NS_DM_NGHENGHIEP : BaseModel
    {
        [Key]
        public string? MaNgheNghiep { get; set; }
public string? TenNgheNghiep { get; set; }

        public NS_DM_NGHENGHIEP()
        {
        }
    }
}

