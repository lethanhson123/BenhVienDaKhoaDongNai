namespace Data_eHospital_DongNai_A.Model
{
    public partial class Duoc_KiemKe : BaseModel
    {
        [Key]
        public int? DuocKiemKe_Id { get; set; }
public int? DuocKyKiemke_Id { get; set; }
public int? KhoDuoc_Id { get; set; }
public int? Duoc_Id { get; set; }
public int? SoLoNhap_Id { get; set; }
public string? DonGiaMua { get; set; }
public string? DonGiaVon { get; set; }
public string? SoLuong { get; set; }
public string? TenDuoc { get; set; }
public string? DVT { get; set; }
public string? SoKiemSoat { get; set; }
public string? NuocSX { get; set; }
public string? Thanhtien { get; set; }
public string? SoThucTe { get; set; }
public string? Thua { get; set; }
public string? Thieu { get; set; }
public string? HongVo { get; set; }
public string? GhiChu { get; set; }
public DateTime? NgayTao { get; set; }
public int? NguoiTao_Id { get; set; }
public DateTime? NgayCapNhat { get; set; }
public int? NguoiCapNhat_Id { get; set; }

        public Duoc_KiemKe()
        {
        }
    }
}

