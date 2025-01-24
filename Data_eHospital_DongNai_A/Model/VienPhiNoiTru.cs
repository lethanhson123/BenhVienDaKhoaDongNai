namespace Data_eHospital_DongNai_A.Model
{
    public partial class VienPhiNoiTru : BaseModel
    {
        [Key]
        public int? VienPhiNoiTru_Id { get; set; }
public string? SoChungTu { get; set; }
public string? LoaiChungTu { get; set; }
public int? BenhAn_Id { get; set; }
public int? LuuTru_Id { get; set; }
public int? PhatSinh_Noi_Id { get; set; }
public int? PhatSinh_Nguoi_Id { get; set; }
public DateTime? PhatSinh_Ngay { get; set; }
public DateTime? PhatSinh_ThoiGian { get; set; }
public DateTime? Tra_Ngay { get; set; }
public DateTime? Tra_ThoiGian { get; set; }
public int? Tra_Noi_Id { get; set; }
public int? Tra_Nguoi_Id { get; set; }
public int? ThuTien_Noi_Id { get; set; }
public int? ThuTien_Nguoi_Id { get; set; }
public DateTime? ThuTien_Ngay { get; set; }
public DateTime? ThuTien_ThoiGian { get; set; }
public int? Huy_Noi_Id { get; set; }
public int? Huy_Nguoi_Id { get; set; }
public DateTime? Huy_Ngay { get; set; }
public DateTime? Huy_ThoiGian { get; set; }
public bool? DaThanhToan { get; set; }
public bool? HuyHoaDon { get; set; }
public bool? HoanTra { get; set; }
public string? GiaTriHoaDon { get; set; }
public decimal? TyleMienGiam { get; set; }
public decimal? GiaTriMienGiam { get; set; }
public decimal? TyLeThatThu { get; set; }
public decimal? GiaTriThatThu { get; set; }
public string? LoaiTien_Id { get; set; }
public decimal? TyGia { get; set; }
public decimal? TyLeVAT { get; set; }
public decimal? GiaTriVAT { get; set; }
public int? HinhThucThanhToan_Id { get; set; }
public int? HoaDonLienQuan_Id { get; set; }
public int? DangKyHoaDon_Id { get; set; }
public string? SoSerieVAT { get; set; }
public int? SoHoaDonVAT { get; set; }
public string? GhiChu { get; set; }
public string? TrangThai { get; set; }
public DateTime? NgayTao { get; set; }
public int? NguoiTao_Id { get; set; }
public DateTime? NgayCapNhat { get; set; }
public int? NguoiCapNhat_Id { get; set; }
public int? IDChuyen { get; set; }
public int? Status { get; set; }
public int? Transfer_VienPhi_Id { get; set; }
public int? DoiTuong_Id { get; set; }
public int? InLai_TamUng { get; set; }
public int? InLai_HoanUng { get; set; }
public int? InLai_BienLaiTaiChinh { get; set; }
public int? InLai_User_Id { get; set; }
public int? IDChuyenHuy { get; set; }
public int? IDChuyenHoan { get; set; }
public string? ThuHD_BL { get; set; }
public string? TenCongTy { get; set; }
public string? MaSoThue { get; set; }
public string? DiaChiCongTy { get; set; }
public int? ChuyenChungTuID { get; set; }
public int? ChuyenChungTuHoanID { get; set; }
public int? ChuyenChungTuHuyID { get; set; }
public int? ChuyenDoanhThuID { get; set; }
public int? ChuyenDoanhThuHoanID { get; set; }
public int? ChuyenDoanhThuHuyID { get; set; }
public string? ChungTuDoiUng { get; set; }
public int? OtherSite_VienPhiNoiTru_Id { get; set; }
public string? SiteCode { get; set; }
public bool? DaChuyenKhu { get; set; }

        public VienPhiNoiTru()
        {
        }
    }
}

