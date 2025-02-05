namespace Data_eHospital_DongNai_A_NSTL.Model
{
    public partial class NS_DM_NgachLuong : BaseModel
    {
        [Key]
        public string? MaNgach { get; set; }
public string? TenNgach { get; set; }
public string? GhiChu { get; set; }
public string? NhomNgach { get; set; }

        public NS_DM_NgachLuong()
        {
        }
    }
}

