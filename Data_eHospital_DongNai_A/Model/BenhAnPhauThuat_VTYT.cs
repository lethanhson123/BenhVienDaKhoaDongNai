namespace Data_eHospital_DongNai_A.Model
{
    public partial class BenhAnPhauThuat_VTYT : BaseModel
    {
        [Key]
        public int? BenhAnPhauThuat_VTYT_Id { get; set; }
public int? BenhAnPhauThuat_Id { get; set; }
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
public string? GhiChu { get; set; }
public int? ChungTuTongHop_Id { get; set; }
public int? KhoSuDung_Id { get; set; }
public bool? TinhTien { get; set; }
public decimal? SoTienThucTe { get; set; }
public decimal? SoTienMienGiam { get; set; }
public decimal? SoTienThatThu { get; set; }
public decimal? SoTienConLai { get; set; }
public decimal? SoTienDaThanhToan { get; set; }
public DateTime? NgaySuDung { get; set; }
public int? NguonHang_Id { get; set; }
public bool? DaThanhToan_MotPhan { get; set; }
public bool? DaThanhToan_HoanTat { get; set; }
public string? DonGiaChenhLech { get; set; }
public string? DonGiaHoTroChenhLech { get; set; }
public decimal? SoTienDaThanhToan_ChenhLech { get; set; }
public decimal? SoTienDaThanhToan_HoTroChenhLech { get; set; }
public string? TrangThai_Xem { get; set; }
public int? NguonGocDuLieu { get; set; }
public int? NguoiTao_Id { get; set; }
public DateTime? NgayTao { get; set; }
public bool? KTC { get; set; }
public int? SoThuTu { get; set; }
public decimal? DonGiaHoTro_KTC { get; set; }
public decimal? DonGiaHoTroChiTra_KTC { get; set; }

        public BenhAnPhauThuat_VTYT()
        {
        }
    }
}

