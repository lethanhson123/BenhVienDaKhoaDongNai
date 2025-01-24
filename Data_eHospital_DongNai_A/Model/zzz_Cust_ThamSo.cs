namespace Data_eHospital_DongNai_A.Model
{
    public partial class zzz_Cust_ThamSo : BaseModel
    {
        [Key]
        public string? TenThamSo { get; set; }
public bool? TamNgung { get; set; }

        public zzz_Cust_ThamSo()
        {
        }
    }
}

