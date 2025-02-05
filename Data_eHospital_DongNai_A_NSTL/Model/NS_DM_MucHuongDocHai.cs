namespace Data_eHospital_DongNai_A_NSTL.Model
{
    public partial class NS_DM_MucHuongDocHai : BaseModel
    {
        [Key]
        public string? MaMucHuongDocHai { get; set; }
public decimal? DonGiaHuong { get; set; }
public string? GhiChu { get; set; }

        public NS_DM_MucHuongDocHai()
        {
        }
    }
}

