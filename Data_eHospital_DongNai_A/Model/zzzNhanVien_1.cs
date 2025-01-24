namespace Data_eHospital_DongNai_A.Model
{
    public partial class zzzNhanVien_1 : BaseModel
    {
        [Key]
        public int? STT { get; set; }
public string? MA_KHOA { get; set; }
public string? TEN_KHOA { get; set; }
public string? MA_BHXH { get; set; }
public string? HO_TEN { get; set; }
public int? GIOI_TINH { get; set; }
public string? MACCHN { get; set; }

        public zzzNhanVien_1()
        {
        }
    }
}

