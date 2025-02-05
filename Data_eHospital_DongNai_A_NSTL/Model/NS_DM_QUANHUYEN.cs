namespace Data_eHospital_DongNai_A_NSTL.Model
{
    public partial class NS_DM_QUANHUYEN : BaseModel
    {
        [Key]
        public string? MaQuanHuyen { get; set; }
public string? TenQuanHuyen { get; set; }
public string? MaTinh { get; set; }
public string? DangSuDung { get; set; }

        public NS_DM_QUANHUYEN()
        {
        }
    }
}

