namespace Data_eHospital_DongNai_A.Model
{
    public partial class BENHNHAN_THEATM : BaseModel
    {
        [Key]
        public int? BENHNHAN_THEATM_ID { get; set; }
public string? MAYTE { get; set; }
public string? CMND { get; set; }
public string? SOTHEATM { get; set; }
public int? LOAITHE_ID { get; set; }
public int? NGUOITAO_ID { get; set; }
public DateTime? NGAYTAO { get; set; }
public int? NGUOICAPNHAT_ID { get; set; }
public DateTime? NGAYCAPNHAT { get; set; }
public int? ACTIVE { get; set; }
public string? TENCHUTHE { get; set; }
public int? MENHGIATHE_ID { get; set; }
public int? BENHNHAN_ID { get; set; }
public string? SOVAOVIEN2 { get; set; }
public string? NGAYPHATHANHTHE { get; set; }
public string? SODIENTHOAI { get; set; }

        public BENHNHAN_THEATM()
        {
        }
    }
}

