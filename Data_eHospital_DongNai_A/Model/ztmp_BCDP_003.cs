namespace Data_eHospital_DongNai_A.Model
{
    public partial class ztmp_BCDP_003 : BaseModel
    {
        [Key]
        public long? STT { get; set; }
public string? TenKho { get; set; }
public decimal? DauKy { get; set; }
public decimal? TongLuongNhap { get; set; }
public decimal? TongLuongXuat { get; set; }

        public ztmp_BCDP_003()
        {
        }
    }
}

