namespace Data_eHospital_DongNai_A.Model
{
    public partial class zzz_CLSYeuCauChiTiet : BaseModel
    {
        [Key]
        public int? YeuCauChiTiet_id { get; set; }
public int? CLSYeuCau_id { get; set; }
public string? TenDichVu { get; set; }

        public zzz_CLSYeuCauChiTiet()
        {
        }
    }
}

