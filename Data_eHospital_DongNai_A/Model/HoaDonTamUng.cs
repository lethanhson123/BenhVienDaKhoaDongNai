namespace Data_eHospital_DongNai_A.Model
{
    public partial class HoaDonTamUng : BaseModel
    {
        [Key]
        public int? HoaDonTamUng_Id { get; set; }
public string? SoChungTu { get; set; }
public DateTime? Ngay { get; set; }
public string? LoaiCT { get; set; }
public string? Loai { get; set; }
public int? BenhAn_Id { get; set; }
public int? NoiPhatSinh_Id { get; set; }
public string? SoHoaDon { get; set; }
public string? SoSeries { get; set; }
public string? GiaTriHoaDon { get; set; }
public string? LoaiTien_Id { get; set; }
public string? TyGia { get; set; }
public string? TyLeVAT { get; set; }
public string? GiaTriVAT { get; set; }
public int? NoiThuTien_Id { get; set; }
public int? NguoiThuTien_Id { get; set; }
public DateTime? NgayThuTien { get; set; }
public string? DienGiai { get; set; }
public string? TrangThai { get; set; }
public DateTime? NgayTao { get; set; }
public int? NguoiTao_Id { get; set; }
public DateTime? NgayCapNhat { get; set; }
public int? NguoiCapNhat_Id { get; set; }

        public HoaDonTamUng()
        {
        }
    }
}

