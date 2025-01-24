namespace Data_eHospital_DongNai_A.Model
{
    public partial class ThongTinCapCuu : BaseModel
    {
        [Key]
        public int? ThongTinCapCuu_Id { get; set; }
public string? SoCapCuu { get; set; }
public int? TiepNhan_Id { get; set; }
public int? BenhAn_Id { get; set; }
public int? LuuTru_Id { get; set; }
public int? BenhNhan_Id { get; set; }
public DateTime? NgayCapCuu { get; set; }
public DateTime? ThoiGianCapCuu { get; set; }
public int? NoiCapCuu_Id { get; set; }
public int? BacSiCapCuu_Id { get; set; }
public string? ChanDoanNGT { get; set; }
public int? ICD_BenhChinh { get; set; }
public int? ICD_BenhPhu { get; set; }
public int? KetQuaCapCuu_Id { get; set; }
public string? GhiChu { get; set; }
public int? KhoaNhapVien_Id { get; set; }
public DateTime? NgayNhapVien { get; set; }
public DateTime? ThoiGianNhapVien { get; set; }
public int? ICD_NhapVien { get; set; }
public string? ChanDoanNhapVien { get; set; }
public int? ChuyenVien_Id { get; set; }
public DateTime? NgayRaVien { get; set; }
public DateTime? ThoiGianRaVien { get; set; }
public int? NguoiTao_Id { get; set; }
public DateTime? NgayTao { get; set; }
public int? NguoiCapNhat_Id { get; set; }
public DateTime? NgayCapNhat { get; set; }

        public ThongTinCapCuu()
        {
        }
    }
}

