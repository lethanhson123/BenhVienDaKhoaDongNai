namespace Data_eHospital_DongNai_A.Model
{
    public partial class VTB_NAPRUTTIEN : BaseModel
    {
        [Key]
        public int? NAPRUTTIEN_ID { get; set; }
public string? MAGIAODICH { get; set; }
public int? BENHNHAN_ID { get; set; }
public string? MAYTE { get; set; }
public string? CMND { get; set; }
public string? SOTHEATM { get; set; }
public string? NGAYPHATHANHTHE { get; set; }
public string? TENCHUTHE { get; set; }
public int? LOAITHE_ID { get; set; }
public string? LOAIGIAODICH { get; set; }
public decimal? SOTIEN { get; set; }
public DateTime? THOIGIANGIAODICH { get; set; }
public string? TRANGTHAIGIAODICH { get; set; }
public int? NGUOITAO_ID { get; set; }
public DateTime? NGAYTAO { get; set; }
public int? NGUOICAPNHAT_ID { get; set; }
public DateTime? NGAYCAPNHAT { get; set; }

        public VTB_NAPRUTTIEN()
        {
        }
    }
}

