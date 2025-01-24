namespace Data_eHospital_DongNai_A.Model
{
    public partial class VienPhiNoiTruChiTiet : BaseModel
    {
        [Key]
        public int? VienPhiNoiTruChiTiet_Id { get; set; }
public int? VienPhiNoiTru_Id { get; set; }
public int? IDRef { get; set; }
public string? Loai_IDRef { get; set; }
public int? PhongBan_Id { get; set; }
public decimal? DonGiaDoanhThu { get; set; }
public decimal? DonGiaHoTro { get; set; }
public decimal? DonGiaHoTroChiTra { get; set; }
public decimal? DonGiaThanhToan { get; set; }
public decimal? SoLuong { get; set; }
public decimal? GiaTriHoaDon { get; set; }
public decimal? TyLeMienGiam { get; set; }
public decimal? GiaTriMienGiam { get; set; }
public decimal? TyLeThatThu { get; set; }
public decimal? GiaTriThatThu { get; set; }
public decimal? TyGia { get; set; }
public string? GhiChu { get; set; }
public int? NguoiTao_Id { get; set; }
public DateTime? NgayTao { get; set; }
public int? NguoiCapNhat_Id { get; set; }
public DateTime? NgayCapNhat { get; set; }
public int? CLSYeuCauChiTiet_Id { get; set; }
public int? NoiTru_ToaThuoc_Id { get; set; }
public int? NoiTru_TraThuoc_Id { get; set; }
public int? BenhAnPhauThuat_VTYT_Id { get; set; }
public int? NoiTru_GiuongBenh_Id { get; set; }
public int? CLSGhiNhanHoaChat_Id { get; set; }
public int? NoiDung_Id { get; set; }
public string? LoaiNoiDung { get; set; }
public int? DoiTuong_Id { get; set; }
public decimal? DonGiaChenhLech { get; set; }
public decimal? DonGiaHoTroChenhLech { get; set; }
public decimal? GiaTriHoaDon_ChenhLech { get; set; }
public decimal? GiaTriMienGiam_ChenhLech { get; set; }
public decimal? GiaTriThatThu_ChenhLech { get; set; }
public decimal? GiaTriHoaDon_HoTroChenhLech { get; set; }
public decimal? GiaTriMienGiam_HoTroChenhLech { get; set; }
public decimal? GiaTriThatThu_HoTroChenhLech { get; set; }
public decimal? DonGiaCoPhan { get; set; }
public decimal? GiaTriHoaDon_CoPhan { get; set; }
public decimal? GiaTriMienGiam_CoPhan { get; set; }
public decimal? GiaTriThatThu_CoPhan { get; set; }
public string? SiteCode { get; set; }
public string? TenNoiPhatSinh { get; set; }
public string? TenLoaiGia { get; set; }
public string? NoiDungChiTiet { get; set; }
public DateTime? NgayPhatSinh { get; set; }
public decimal? GiaTriGhiNhan_ChenhLech { get; set; }
public decimal? GiaTriGhiNhan_HoTroChenhLech { get; set; }
public decimal? GiaTriGhiNhan_CoPhan { get; set; }
public string? MaNhom { get; set; }
public string? TenNhom { get; set; }
public string? MaLoai { get; set; }
public string? TenLoai { get; set; }
public string? LoaiVatTu { get; set; }

        public VienPhiNoiTruChiTiet()
        {
        }
    }
}

