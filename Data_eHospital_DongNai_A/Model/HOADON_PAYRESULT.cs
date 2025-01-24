namespace Data_eHospital_DongNai_A.Model
{
    public partial class HOADON_PAYRESULT : BaseModel
    {
        [Key]
        public int? HOADON_PAYRESULT_ID { get; set; }
public int? SOHOADON { get; set; }
public string? TRANSACTION_ID { get; set; }
public string? TRANS_CONFIRM { get; set; }
public DateTime? NGAYGIO_REQUEST { get; set; }
public DateTime? NGAYGIO_CONFIRM { get; set; }
public string? BANK_TRX_ID { get; set; }
public string? TIENTE_ID { get; set; }
public decimal? GIATRIHOADON { get; set; }
public string? RESPONSECODE { get; set; }
public string? MTI { get; set; }
public string? REFUND_ID { get; set; }
public string? SOTHE { get; set; }
public string? MESSAGE { get; set; }
public string? MESSAGE_RESPONSE { get; set; }
public string? LAST_RESPONSECODE { get; set; }
public string? PROCESSINGCODE { get; set; }
public DateTime? NGAY_CONFIRM { get; set; }
public string? LOAIHOADON { get; set; }
public string? RESPONSECODE_VTB { get; set; }
public decimal? SOTIEN_VTB { get; set; }

        public HOADON_PAYRESULT()
        {
        }
    }
}

