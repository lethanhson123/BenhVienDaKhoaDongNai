namespace Data_eHospital_DongNai_A.Model
{
    public partial class BHYT_KiemTra2 : BaseModel
    {
        [Key]
        public string? HO_TEN { get; set; }
public string? MA_THE { get; set; }
public DateTime? NGAY_VAO { get; set; }
public DateTime? NGAY_RA { get; set; }
public string? MA_BENH { get; set; }
public DateTime? NGAY_YL { get; set; }

        public BHYT_KiemTra2()
        {
        }
    }
}

