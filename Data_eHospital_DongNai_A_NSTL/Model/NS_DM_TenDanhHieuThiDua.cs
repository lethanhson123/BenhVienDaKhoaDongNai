namespace Data_eHospital_DongNai_A_NSTL.Model
{
    public partial class NS_DM_TenDanhHieuThiDua : BaseModel
    {
        [Key]
        public string? Ma { get; set; }
public string? TenDanhHieu { get; set; }
public decimal? Diem { get; set; }
public string? GhiChu { get; set; }

        public NS_DM_TenDanhHieuThiDua()
        {
        }
    }
}

