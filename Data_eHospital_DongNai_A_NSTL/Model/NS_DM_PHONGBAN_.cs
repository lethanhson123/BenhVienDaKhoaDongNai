namespace Data_eHospital_DongNai_A_NSTL.Model
{
    public partial class NS_DM_PHONGBAN_ : BaseModel
    {
        [Key]
        public string? MaPhongBan { get; set; }
public string? TenPhongBan { get; set; }
public int? ThuTuSapXep { get; set; }

        public NS_DM_PHONGBAN_()
        {
        }
    }
}

