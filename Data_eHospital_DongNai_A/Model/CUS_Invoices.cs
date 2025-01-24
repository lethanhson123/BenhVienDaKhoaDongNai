namespace Data_eHospital_DongNai_A.Model
{
    public partial class CUS_Invoices : BaseModel
    {
        [Key]
        public int? Fkey { get; set; }
public string? Serial { get; set; }
public string? Pattern { get; set; }
public string? No { get; set; }
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
public Guid? TransID { get; set; }
public Guid? FileID { get; set; }
public string? BranchCode { get; set; }

        public CUS_Invoices()
        {
        }
    }
}

