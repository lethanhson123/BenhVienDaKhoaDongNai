namespace Data_eHospital_DongNai_A_NSTL.Model
{
    public partial class NS_BANGCAP_UV : BaseModel
    {
        [Key]
        public int? Id { get; set; }
public string? MaUngVien { get; set; }
public string? TenBangcap { get; set; }
public string? ChuyenNganh { get; set; }
public string? Noicapbang { get; set; }
public DateTime? Ngaycapbang { get; set; }
public string? Xeploai { get; set; }

        public NS_BANGCAP_UV()
        {
        }
    }
}

