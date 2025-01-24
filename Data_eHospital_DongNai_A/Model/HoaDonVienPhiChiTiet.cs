namespace Data_eHospital_DongNai_A.Model
{
    public partial class HoaDonVienPhiChiTiet : BaseModel
    {
        [Key]
        public int? HoaDonChiTiet_Id { get; set; }
public int? HoaDonVienPhi_Id { get; set; }
public int? NoiDung_Id { get; set; }
public string? SoPhatSinh { get; set; }
public bool? MienPhi { get; set; }
public string? TyLeMienGiam { get; set; }
public string? SoThucThu { get; set; }
public string? DienGiai { get; set; }

        public HoaDonVienPhiChiTiet()
        {
        }
    }
}

