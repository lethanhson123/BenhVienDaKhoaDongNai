namespace Data_eHospital_DongNai_A_NSTL.Model
{
    public partial class NS_BANGCAP : BaseModel
    {
        [Key]
        public int? ID { get; set; }
public string? MaNhanVien { get; set; }
public string? TenBangCap { get; set; }
public string? ChuyenNganh { get; set; }
public string? Noicapbang { get; set; }
public DateTime? Ngaycapbang { get; set; }
public string? Xeploai { get; set; }
public string? SoVanBang { get; set; }
public string? NganhHoc { get; set; }
public string? HinhThucDaoTao { get; set; }
public int? DuaLenBaoCao { get; set; }

        public NS_BANGCAP()
        {
        }
    }
}

