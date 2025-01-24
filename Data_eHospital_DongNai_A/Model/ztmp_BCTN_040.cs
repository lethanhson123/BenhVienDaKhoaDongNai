namespace Data_eHospital_DongNai_A.Model
{
    public partial class ztmp_BCTN_040 : BaseModel
    {
        [Key]
        public string? TenBenhNhan { get; set; }
public int? NamSinh { get; set; }
public string? GioiTinh { get; set; }
public string? DiaChi { get; set; }
public string? DoiTuong { get; set; }
public string? SoDienThoai { get; set; }
public DateTime? NgayTiepNhan { get; set; }
public string? PhongBan { get; set; }
public string? MaYTe { get; set; }

        public ztmp_BCTN_040()
        {
        }
    }
}

