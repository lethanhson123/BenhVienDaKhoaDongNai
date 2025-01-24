namespace Data_eHospital_DongNai_A.Model
{
    public partial class zzz_DM_BS_BHYT : BaseModel
    {
        [Key]
        public int? STT { get; set; }
public string? MA_KHOA { get; set; }
public string? MANHANVIEN { get; set; }
public string? TEN_NHANVIEN { get; set; }
public string? CHUCDANH { get; set; }
public string? MACCHN { get; set; }
public DateTime? NGAYCAP_CCHN { get; set; }
public string? MA_BHXH { get; set; }

        public zzz_DM_BS_BHYT()
        {
        }
    }
}

