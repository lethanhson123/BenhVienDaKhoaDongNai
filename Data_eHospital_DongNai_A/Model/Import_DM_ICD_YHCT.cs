namespace Data_eHospital_DongNai_A.Model
{
    public partial class Import_DM_ICD_YHCT : BaseModel
    {
        [Key]
        public int? STT { get; set; }
public string? MA_BENH { get; set; }
public string? CHUNG_BENH { get; set; }
public string? ICD10 { get; set; }
public string? TEN_BENH_YHHD { get; set; }
public string? TEN_BENH { get; set; }
public string? CHUONG { get; set; }

        public Import_DM_ICD_YHCT()
        {
        }
    }
}

