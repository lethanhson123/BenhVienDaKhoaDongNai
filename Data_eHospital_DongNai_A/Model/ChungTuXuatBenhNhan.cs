namespace Data_eHospital_DongNai_A.Model
{
    public partial class ChungTuXuatBenhNhan : BaseModel
    {
        [Key]
        public int? ChungTuXuatBN_Id { get; set; }
public int? ChungTuChiTiet_Id { get; set; }
public int? BenhAnPhauThuat_VTYT_ID { get; set; }
public int? ToaThuoc_Id { get; set; }
public int? BenhAn_Id { get; set; }
public int? Duoc_Id { get; set; }
public int? SoLoNhap_Id { get; set; }
public int? NguonHang_Id { get; set; }
public decimal? SoLuong { get; set; }
public decimal? DonGiaVon { get; set; }
public decimal? DonGiaMua { get; set; }
public decimal? DonGiaHoTro { get; set; }
public decimal? DonGiaHoTroChiTra { get; set; }
public decimal? DonGiaThanhToan { get; set; }
public decimal? DonGiaDoanhThu { get; set; }
public int? ToaThuocNgoaiTru_id { get; set; }
public int? TiepNhan_id { get; set; }
public int? ToaThuocTra_Id { get; set; }
public int? CLSHoaChat_VTYT_Id { get; set; }
public bool? PhatSinhHoaDon { get; set; }
public string? Loai_IDRef { get; set; }
public int? IDRef { get; set; }
public string? GiaTriMienGiam { get; set; }
public string? GiaTriThatThu { get; set; }
public string? GiaTriDaThanhToan { get; set; }
public bool? DaThanhToan_MotPhan { get; set; }
public bool? DaThanhToan_HoanTat { get; set; }
public string? DonGiaChenhLech { get; set; }
public string? DonGiaHoTroChenhLech { get; set; }
public decimal? GiaTriDaThanhToan_ChenhLech { get; set; }
public decimal? GiaTriDaThanhToan_HoTroChenhLech { get; set; }
public bool? DaThuTien { get; set; }
public bool? MienPhi { get; set; }
public int? KhamBenh_VTYT_Id { get; set; }
public int? ToaThuoc_BA_NgoaiTru_Id { get; set; }
public decimal? GiaTriMienGiam_ChenhLech { get; set; }
public decimal? GiaTriMienGiam_HoTroChenhLech { get; set; }
public decimal? GiaTriMienGiam_CoPhan { get; set; }
public decimal? DonGiaHoTro_KTC { get; set; }
public decimal? DonGiaHoTroChiTra_KTC { get; set; }
public string? TyLeKTC { get; set; }

        public ChungTuXuatBenhNhan()
        {
        }
    }
}

