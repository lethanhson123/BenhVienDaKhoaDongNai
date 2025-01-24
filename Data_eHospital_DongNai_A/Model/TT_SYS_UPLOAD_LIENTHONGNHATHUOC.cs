namespace Data_eHospital_DongNai_A.Model
{
    public partial class TT_SYS_UPLOAD_LIENTHONGNHATHUOC : BaseModel
    {
        [Key]
        public int? ID { get; set; }
public int? REF_ID { get; set; }
public string? REF_TABLE { get; set; }
public string? LOAI_IDREFD { get; set; }
public string? BENHVIEN_ID { get; set; }
public DateTime? THOIGIAN_UPLOAD { get; set; }
public string? TRANGTHAI_UPLOAD { get; set; }
public int? TIEPNHAN_ID { get; set; }
public int? BENHNHAN_ID { get; set; }
public string? TENBENHNHAN { get; set; }
public string? PHIENLAMVIEC { get; set; }
public string? LYDO { get; set; }
public string? MA_RETURN { get; set; }
public int? STT_NT { get; set; }

        public TT_SYS_UPLOAD_LIENTHONGNHATHUOC()
        {
        }
    }
}

