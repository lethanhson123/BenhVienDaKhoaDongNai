namespace Data_eHospital_DongNai_A_NSTL.Model
{
    public partial class NS_DM_ThoiGianDiHoc : BaseModel
    {
        [Key]
        public int? ThoiGianDiHoc_Id { get; set; }
public string? Ma { get; set; }
public string? Ten { get; set; }
public string? GhiChu { get; set; }
public bool? Enable { get; set; }

        public NS_DM_ThoiGianDiHoc()
        {
        }
    }
}

