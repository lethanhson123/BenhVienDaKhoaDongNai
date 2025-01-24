namespace Data_eHospital_DongNai_A.Model
{
    public partial class EMR : BaseModel
    {
        [Key]
        public int? ID { get; set; }
public int? BENHAN_ID { get; set; }
public int? LOAIBENHAN_ID { get; set; }
public string? SOBENHAN { get; set; }
public string? MAYTE { get; set; }
public string? TENBENHNHAN { get; set; }
public int? NAMSINH { get; set; }
public string? GIOITINH { get; set; }
public string? FILENAME { get; set; }
public DateTime? NGAYTAO { get; set; }
public string? NGUOICHUYEN { get; set; }
public DateTime? NGAYRAVIEN { get; set; }

        public EMR()
        {
        }
    }
}

