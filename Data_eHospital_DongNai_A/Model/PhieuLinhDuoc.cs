namespace Data_eHospital_DongNai_A.Model
{
    public partial class PhieuLinhDuoc : BaseModel
    {
        [Key]
        public int? ChungTu_Id { get; set; }
public string? MaChungTu { get; set; }
public string? SoChungTu { get; set; }
public DateTime? NgayChungTu { get; set; }
public string? LoaiChungTu { get; set; }
public int? MucDichChungTu_Id { get; set; }
public int? KhoXuat_Id { get; set; }
public int? NguoiGiao_Id { get; set; }
public string? NguoiGiao { get; set; }
public int? KhoNhap_Id { get; set; }
public int? NguoiNhan_Id { get; set; }
public string? NguoiNhan { get; set; }
public string? NguoiKiemTra { get; set; }
public string? NguoiDuyet { get; set; }
public string? KeToanTruong { get; set; }
public string? ThuKho { get; set; }
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
public string? SoChungTuGoc { get; set; }
public DateTime? NgayChungTuGoc { get; set; }
public int? NhaCungCap_Id { get; set; }
public int? HinhThucThanhToan_Id { get; set; }
public int? NguonDuoc_Id { get; set; }
public int? ChungTuLienQuan_Id { get; set; }
public int? ToaThuoc_Id { get; set; }
public int? ToaThuocNoiTru_Id { get; set; }
public int? BenhAn_Id { get; set; }
public bool? DaNhanThuoc { get; set; }
public int? NguoiNhap_Id { get; set; }
public DateTime? NgayNhap { get; set; }
public string? TrangThai { get; set; }
public DateTime? NgayTao { get; set; }
public int? NguoiTao_Id { get; set; }
public DateTime? NgayCapNhat { get; set; }
public int? NguoiCapNhat_Id { get; set; }
public int? PhieuLinh_Id { get; set; }
public string? DienGiaiNghiepVuPhatSinh { get; set; }
public DateTime? TongHop_TuNgay { get; set; }
public DateTime? TongHop_DenNgay { get; set; }
public bool? CoSo { get; set; }
public bool? TongHop { get; set; }
public string? Phanloaiphieulinh { get; set; }
public int? Duyet { get; set; }
public DateTime? NgayDuyet { get; set; }
public DateTime? ThoiGianDuyet { get; set; }
public int? NguoiDuyet_Id { get; set; }
public string? LyDo { get; set; }

        public PhieuLinhDuoc()
        {
        }
    }
}

