namespace Data_eHospital_DongNai_A.Model
{
    public partial class Duoc_DonDatHang : BaseModel
    {
        [Key]
        public int? DonDatHang_Id { get; set; }
public string? MaChungTu { get; set; }
public string? SoChungTu { get; set; }
public DateTime? NgayChungTu { get; set; }
public string? LoaiChungTu { get; set; }
public int? MucDichDonDatHang_Id { get; set; }
public int? KhoLap_Id { get; set; }
public int? NguoiLap_Id { get; set; }
public string? NguoiLap { get; set; }
public string? SoSeri { get; set; }
public string? SoHoaDon { get; set; }
public string? DienGiai { get; set; }
public string? GiaTri { get; set; }
public string? GiaTriThanhToan { get; set; }
public string? TyLeVat { get; set; }
public string? GiaTriVat { get; set; }
public string? ThueSuat { get; set; }
public string? GiaTriThue { get; set; }
public string? TyleChietKhau { get; set; }
public string? GiaTriChietKhau { get; set; }
public string? TienTe_Id { get; set; }
public string? TyGia { get; set; }
public int? NhaCungCap_Id { get; set; }
public int? NhaNhapKhau_Id { get; set; }
public int? HinhThucThanhToan_Id { get; set; }
public int? NguonDuoc_Id { get; set; }
public int? ChungTuLienQuan_Id { get; set; }
public bool? DaNhanThuoc { get; set; }
public string? TrangThai { get; set; }
public DateTime? NgayTao { get; set; }
public int? NguoiTao_Id { get; set; }
public DateTime? NgayCapNhat { get; set; }
public int? NguoiCapNhat_Id { get; set; }
public string? DienGiaiNghiepVuPhatSinh { get; set; }
public int? DuTru_Id { get; set; }

        public Duoc_DonDatHang()
        {
        }
    }
}

