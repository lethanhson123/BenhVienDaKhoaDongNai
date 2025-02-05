namespace Data_eHospital_DongNai_A_NSTL.Model
{
    public partial class NS_SYS_HANGSO : BaseModel
    {
        [Key]
        public string? MaThongTin { get; set; }
public string? GiaTri { get; set; }
public string? GhiChu { get; set; }

        public NS_SYS_HANGSO()
        {
        }
    }
}

