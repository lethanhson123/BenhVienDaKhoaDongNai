namespace Data_eHospital_DongNai_A_NSTL.Model
{
    public partial class NS_DM_NGAYLE : BaseModel
    {
        [Key]
        public string? MaNgayLe { get; set; }
public DateTime? Ngay { get; set; }
public string? TenNgayLe { get; set; }

        public NS_DM_NGAYLE()
        {
        }
    }
}

