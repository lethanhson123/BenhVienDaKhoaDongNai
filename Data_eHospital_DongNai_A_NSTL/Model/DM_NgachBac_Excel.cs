namespace Data_eHospital_DongNai_A_NSTL.Model
{
    public partial class DM_NgachBac_Excel : BaseModel
    {
        [Key]
        public float? STT { get; set; }
public string? MaNV { get; set; }
public float? Ngach { get; set; }
public string? Ngach1 { get; set; }
public string? Bac { get; set; }
public string? PCTN { get; set; }

        public DM_NgachBac_Excel()
        {
        }
    }
}

