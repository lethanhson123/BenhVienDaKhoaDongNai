namespace Data_eHospital_DongNai_A.Model
{
    public partial class KhamBenh_VTYT : BaseModel
    {
        [Key]
        public int? KhamBenh_VTYT_Id { get; set; }
public int? KhamBenh_Id { get; set; }
public int? Idx { get; set; }
public int? Duoc_Id { get; set; }
public string? SoLuong { get; set; }
public int? LoaiGia_Id { get; set; }
public string? TienTe_Id { get; set; }
public string? TyGia { get; set; }
public string? DonGiaDoanhThu { get; set; }
public string? DonGiaHoTro { get; set; }
public string? DonGiaHoTroChiTra { get; set; }
public string? DonGiaThanhToan { get; set; }
public string? GhiChu { get; set; }
public string? TrangThai { get; set; }
public DateTime? NgayTao { get; set; }
public int? NguoiTao_Id { get; set; }
public DateTime? NgayCapNhat { get; set; }
public int? NguoiCapNhat_Id { get; set; }
public int? PhieuLinh_Id { get; set; }
public int? KhoSuDung_Id { get; set; }
public int? ChungTu_Id { get; set; }
public bool? TinhTien { get; set; }

        public KhamBenh_VTYT()
        {
        }
    }
}

