namespace Data_eHospital_DongNai_A.Model
{
    public partial class TinSMS_LoaiTin : BaseModel
    {
        [Key]
        public string? TinSMS_LoaiTinId { get; set; }
public string? TenLoai { get; set; }
public string? TenBang { get; set; }
public string? GhiChu { get; set; }

        public TinSMS_LoaiTin()
        {
        }
    }
}

