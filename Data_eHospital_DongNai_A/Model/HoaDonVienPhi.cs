namespace Data_eHospital_DongNai_A.Model
{
    public partial class HoaDonVienPhi : BaseModel
    {
        [Key]
        public int? HoaDonVienPhi_Id { get; set; }
public string? SoChungTu { get; set; }
public DateTime? Ngay { get; set; }
public string? LoaiCT { get; set; }
public string? Loai { get; set; }
public int? BenhAn_Id { get; set; }
public int? LuuTru_Id { get; set; }
public int? NoiPhatSinh_Id { get; set; }
public int? NguoiLap_Id { get; set; }
public DateTime? NgayPhatSinh { get; set; }
public DateTime? ThoiGianPhatSinh { get; set; }
public DateTime? NgayTra { get; set; }
public DateTime? ThoiGianTra { get; set; }
public int? NoiTra_Id { get; set; }
public int? NguoiTra_Id { get; set; }
public int? NoiThuTien_Id { get; set; }
public int? NguoiThuTien_Id { get; set; }
public DateTime? NgayThuTien { get; set; }
public DateTime? ThoiGianThuTien { get; set; }
public int? NoiHuy_Id { get; set; }
public int? NguoiHuy_Id { get; set; }
public DateTime? NgayHuy { get; set; }
public DateTime? ThoiGianHuy { get; set; }
public string? GiaTriHoaDon { get; set; }
public string? GiaTriThucThu { get; set; }
public string? LoaiTien_Id { get; set; }
public string? TyGia { get; set; }
public string? TyLeVAT { get; set; }
public string? GiaTriVAT { get; set; }
public int? HinhThucThanhToan_Id { get; set; }
public string? DienGiai { get; set; }
public string? TrangThai { get; set; }
public bool? DaThanhToan { get; set; }
public bool? HuyHoaDon { get; set; }
public bool? HoanTra { get; set; }
public int? HoaDonLienQuan_Id { get; set; }
public string? TyleMienGiam { get; set; }
public string? GiaTriMienGiam { get; set; }
public DateTime? NgayTao { get; set; }
public int? NguoiTao_Id { get; set; }
public DateTime? NgayCapNhat { get; set; }
public int? NguoiCapNhat_Id { get; set; }
public int? BienLaiChiTiet_Id { get; set; }
public string? Series { get; set; }
public int? Series_Number { get; set; }

        public HoaDonVienPhi()
        {
        }
    }
}

