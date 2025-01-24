namespace Data_eHospital_DongNai_A.Model
{
    public partial class zzzBS_KhamTrung : BaseModel
    {
        [Key]
        public string? MA_BAC_SI { get; set; }
public string? TEN_BAC_SI { get; set; }
public string? NGAY_YL { get; set; }
public string? MA_CSKCB { get; set; }
public string? TEN_CSKCB { get; set; }
public string? MA_TINH { get; set; }
public string? TEN_TINH { get; set; }
public string? MA_THE { get; set; }
public string? HO_TEN { get; set; }
public string? XML1_ID { get; set; }
public string? MA_LK { get; set; }

        public zzzBS_KhamTrung()
        {
        }
    }
}

