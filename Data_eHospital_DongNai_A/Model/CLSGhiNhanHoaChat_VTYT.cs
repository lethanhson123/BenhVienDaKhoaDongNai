namespace Data_eHospital_DongNai_A.Model
{
    public partial class CLSGhiNhanHoaChat_VTYT : BaseModel
    {
        [Key]
        public int? Id { get; set; }
public int? CLSYeuCau_Id { get; set; }
public int? Duoc_Id { get; set; }
public string? SoLuong { get; set; }
public int? LoaiGia_Id { get; set; }
public string? DonGiaDoanhThu { get; set; }
public string? DonGiaHoTro { get; set; }
public string? DonGiaHoTroChiTra { get; set; }
public string? DonGiaThanhToan { get; set; }
public string? TyLeVAT { get; set; }
public string? GiaTriVAT { get; set; }
public string? TienTe_Id { get; set; }
public string? TyGia { get; set; }
public int? ChungTu_Id { get; set; }
public int? ChungTuTongHop_Id { get; set; }
public string? GhiChu { get; set; }
public int? KhoSuDung_Id { get; set; }
public bool? TinhTien { get; set; }
public decimal? SoTienThucTe { get; set; }
public decimal? SoTienMienGiam { get; set; }
public decimal? SoTienThatThu { get; set; }
public decimal? SoTienConLai { get; set; }
public decimal? SoTienDaThanhToan { get; set; }
public DateTime? NgaySuDung { get; set; }
public int? NguonHang_Id { get; set; }
public int? QuanLyBenhPham_Id { get; set; }
public decimal? DonGiaChenhLech { get; set; }
public decimal? DonGiaHoTroChenhLech { get; set; }
public decimal? GiaTriDaThanhToan_ChenhLech { get; set; }
public decimal? GiaTriDaThanhToan_HoTroChenhLech { get; set; }
public bool? DongChiTra { get; set; }
public int? KhoPhatThuoc_Id { get; set; }

        public CLSGhiNhanHoaChat_VTYT()
        {
        }
    }
}

