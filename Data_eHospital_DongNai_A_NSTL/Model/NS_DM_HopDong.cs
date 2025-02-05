namespace Data_eHospital_DongNai_A_NSTL.Model
{
    public partial class NS_DM_HopDong : BaseModel
    {
        [Key]
        public string? MaHopDong { get; set; }
public string? TenHopDong { get; set; }
public string? Loai { get; set; }
public int? HopDong_Id { get; set; }

        public NS_DM_HopDong()
        {
        }
    }
}

