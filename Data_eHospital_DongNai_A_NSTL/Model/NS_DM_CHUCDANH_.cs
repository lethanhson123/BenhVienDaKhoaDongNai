namespace Data_eHospital_DongNai_A_NSTL.Model
{
    public partial class NS_DM_CHUCDANH_ : BaseModel
    {
        [Key]
        public string? MaChucDanh { get; set; }
public string? TenChucDanh { get; set; }

        public NS_DM_CHUCDANH_()
        {
        }
    }
}

