namespace Data_eHospital_DongNai_A_NSTL.Model
{
    public partial class NS_DM_TINH : BaseModel
    {
        [Key]
        public string? MaTinh { get; set; }
public string? TenTinh { get; set; }
public string? DangSuDung { get; set; }

        public NS_DM_TINH()
        {
        }
    }
}

