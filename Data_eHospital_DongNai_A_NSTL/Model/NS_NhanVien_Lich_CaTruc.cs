namespace Data_eHospital_DongNai_A_NSTL.Model
{
    public partial class NS_NhanVien_Lich_CaTruc : BaseModel
    {
        [Key]
        public int? NhanVien_Lich_CaTruc_Id { get; set; }
public string? NhanVien_Id { get; set; }
public string? Thu { get; set; }
public DateTime? Ngay { get; set; }
public int? CaTruc_Id { get; set; }
public DateTime? BatDau { get; set; }
public DateTime? KetThuc { get; set; }
public string? PhongBan_Id { get; set; }
public bool? TruongTua { get; set; }
public bool? CapCuu { get; set; }
public bool? SAXQ { get; set; }

        public NS_NhanVien_Lich_CaTruc()
        {
        }
    }
}

