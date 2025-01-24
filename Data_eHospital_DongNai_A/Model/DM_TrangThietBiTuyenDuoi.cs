namespace Data_eHospital_DongNai_A.Model
{
    public partial class DM_TrangThietBiTuyenDuoi : BaseModel
    {
        [Key]
        public int? ThietBi_Id { get; set; }
public string? MaThietBi { get; set; }
public string? TenThietBi { get; set; }
public bool? TamNgung { get; set; }
public decimal? TuoiTho { get; set; }
public int? NamSanXuat { get; set; }
public int? NhomThietBi_Id { get; set; }
public int? PhongBan_Id { get; set; }
public string? TenKhongDau { get; set; }
public DateTime? NgayTao { get; set; }
public int? NguoiTao_Id { get; set; }
public DateTime? NgayCapNhat { get; set; }
public int? NguoiCapNhat_Id { get; set; }
public string? NoiSanXuat { get; set; }

        public DM_TrangThietBiTuyenDuoi()
        {
        }
    }
}

