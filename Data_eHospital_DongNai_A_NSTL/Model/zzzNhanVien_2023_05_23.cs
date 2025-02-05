namespace Data_eHospital_DongNai_A_NSTL.Model
{
    public partial class zzzNhanVien_2023_05_23 : BaseModel
    {
        [Key]
        public int? STT { get; set; }
public string? MA_BHXH { get; set; }
public string? HO_TEN { get; set; }
public string? MACCHN { get; set; }
public DateTime? NGAYCAP_CCHN { get; set; }
public string? NOICAP_CCHN { get; set; }

        public zzzNhanVien_2023_05_23()
        {
        }
    }
}

