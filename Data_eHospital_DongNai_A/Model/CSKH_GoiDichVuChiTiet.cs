namespace Data_eHospital_DongNai_A.Model
{
    public partial class CSKH_GoiDichVuChiTiet : BaseModel
    {
        [Key]
        public int? GoiDichVuChiTiet_Id { get; set; }
public int? GoiDichVu_Id { get; set; }
public int? DichVu_Id { get; set; }
public string? TienTe_Id { get; set; }
public string? TyGia { get; set; }
public decimal? DonGiaThanhToan { get; set; }
public decimal? DonGiaDichVu { get; set; }
public int? TyLe { get; set; }
public int? SoLuong { get; set; }
public string? GhiChu { get; set; }
public bool? TamNgung { get; set; }
public DateTime? NgayTao { get; set; }
public int? NguoiTao_Id { get; set; }
public DateTime? NgayCapNhat { get; set; }
public int? NguoiCapNhat_Id { get; set; }
public decimal? Attribute1 { get; set; }
public decimal? Attribute2 { get; set; }
public int? Attribute3 { get; set; }
public int? Attribute4 { get; set; }
public DateTime? Attribute5 { get; set; }
public DateTime? Attribute6 { get; set; }
public string? Attribute7 { get; set; }
public string? Attribute8 { get; set; }
public bool? Attribute9 { get; set; }
public int? QuanHe { get; set; }
public decimal? DonGiaDichVuTrongGoi { get; set; }
public decimal? PhanTram { get; set; }

        public CSKH_GoiDichVuChiTiet()
        {
        }
    }
}

