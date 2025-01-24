namespace Data_eHospital_DongNai_A.Model
{
    public partial class zz_HDDT_Temp : BaseModel
    {
        [Key]
        public int? ID { get; set; }
public string? Fkey { get; set; }
public string? CusCode { get; set; }
public string? CusName { get; set; }
public string? CusAddress { get; set; }
public string? CusPhone { get; set; }
public string? CusTaxCode { get; set; }
public string? CusBankNo { get; set; }
public string? Buyer { get; set; }
public string? PaymentMethod { get; set; }
public string? Total { get; set; }
public string? VATRate { get; set; }
public string? VATAmount { get; set; }
public string? Amount { get; set; }
public string? AmountInWords { get; set; }
public string? Extra { get; set; }
public string? ArisingDate { get; set; }
public DateTime? CreatedDate { get; set; }
public bool? IsPayed { get; set; }
public bool? IsAdjusted { get; set; }
public bool? IsReplaced { get; set; }
public bool? IsCanceled { get; set; }
public int? Status { get; set; }
public string? Error { get; set; }
public string? BranchCode { get; set; }
public int? Status2 { get; set; }
public bool? Synchronized { get; set; }
public DateTime? SyncCreateDate { get; set; }

        public zz_HDDT_Temp()
        {
        }
    }
}

