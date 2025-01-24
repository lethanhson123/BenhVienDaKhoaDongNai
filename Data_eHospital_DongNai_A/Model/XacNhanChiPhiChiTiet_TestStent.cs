namespace Data_eHospital_DongNai_A.Model
{
    public partial class XacNhanChiPhiChiTiet_TestStent : BaseModel
    {
        [Key]
        public int? XacNhanChiPhiChiTiet_Id { get; set; }
public int? XacNhanChiPhi_Id { get; set; }
public string? Loai_IDRef { get; set; }
public int? IDRef { get; set; }
public int? NoiDung_Id { get; set; }
public string? NoiDung { get; set; }
public decimal? SoLuong { get; set; }
public decimal? DonGiaDoanhThu { get; set; }
public decimal? DonGiaHoTro { get; set; }
public decimal? DonGiaHoTroChiTra { get; set; }
public decimal? DonGiaThanhToan { get; set; }
public decimal? SoLuong_New { get; set; }
public decimal? DonGiaHoTroChiTra_New { get; set; }
public string? Loai { get; set; }
public DateTime? NgayCapNhat { get; set; }
public int? NguoiCapNhat_Id { get; set; }
public int? PhongBan_Id { get; set; }
public int? NgoaiTru_ToaThuoc_ID { get; set; }
public int? NoiTru_ToaThuoc_ID { get; set; }
public string? SiteCode_PhatSinh { get; set; }
public string? TenDonViTinh { get; set; }
public int? Center_XN_ChiTiet_ID { get; set; }
public decimal? XN_DonGiaVon { get; set; }
public decimal? XN_DonGiaMua { get; set; }
public string? Tyle_TT { get; set; }
public string? Muc_Huong { get; set; }
public string? Ma_Khoa { get; set; }
public string? Ma_Bac_Si { get; set; }
public DateTime? Ngay_YL { get; set; }
public DateTime? Ngay_KQ { get; set; }
public string? Ma_PTTT { get; set; }
public string? Ma_Giuong { get; set; }
public int? BacSi_Id { get; set; }

        public XacNhanChiPhiChiTiet_TestStent()
        {
        }
    }
}

