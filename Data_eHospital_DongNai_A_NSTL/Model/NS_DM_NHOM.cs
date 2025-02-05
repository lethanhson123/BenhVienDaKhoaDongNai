namespace Data_eHospital_DongNai_A_NSTL.Model
{
    public partial class NS_DM_NHOM : BaseModel
    {
        [Key]
        public string? MaNhom { get; set; }
public string? TenNhom { get; set; }
public string? MaPhongBan { get; set; }

        public NS_DM_NHOM()
        {
        }
    }
}

