namespace Data_eHospital_DongNai_A.Model
{
    public partial class Duoc_DonDatHangChiTiet : BaseModel
    {
        [Key]
        public int? DonDatHangChiTiet_Id { get; set; }
public int? DonDatHang_Id { get; set; }
public int? Duoc_Id { get; set; }
public string? SoVisa { get; set; }
public int? DonViTinh_Id { get; set; }
public string? SoLuongYeuCau { get; set; }
public string? SoLuongThucTe { get; set; }
public string? SoLuongDaXuat { get; set; }
public string? TienTe_Id { get; set; }
public string? TyGia { get; set; }
public string? DonGiaMua { get; set; }
public string? DonGiaBan { get; set; }
public string? DonGiaVon { get; set; }
public string? DonGiaThanhToan { get; set; }
public string? SoQuyen { get; set; }
public string? SoHoaDonVAT { get; set; }
public string? TyLeVAT { get; set; }
public string? GiaTriVAT { get; set; }
public bool? MienPhi { get; set; }
public int? LyDoMienPhi_Id { get; set; }
public string? SoChungTuKeToan { get; set; }
public string? SoChungTuTienMat { get; set; }
public string? TrangThai { get; set; }
public bool? DaPhatSinhPhieuXuat { get; set; }
public bool? DaPhatSinhPhieuHoanTra { get; set; }
public DateTime? NgayTao { get; set; }
public int? NguoiTao_Id { get; set; }
public DateTime? NgayCapNhat { get; set; }
public int? NguoiCapNhat_Id { get; set; }

        public Duoc_DonDatHangChiTiet()
        {
        }
    }
}

