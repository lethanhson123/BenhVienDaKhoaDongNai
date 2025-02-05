namespace Data_eHospital_DongNai_A_NSTL.Model
{
    public partial class NS_NHANVIEN : BaseModel
    {
        [Key]
        public string? MaNhanVien { get; set; }
public string? Ho { get; set; }
public string? Ten { get; set; }
public string? HinhAnh { get; set; }
public DateTime? NgaySinh { get; set; }
public string? NoiSinh { get; set; }
public string? GioiTinh { get; set; }
public string? MaDanToc { get; set; }
public string? MaQuocTich { get; set; }
public string? MaTonGiao { get; set; }
public string? Quequan { get; set; }
public string? DiaChihokhau { get; set; }
public string? DiaChiLienhe { get; set; }
public string? Passport { get; set; }
public string? SoTaikhoan { get; set; }
public string? Nganhang { get; set; }
public string? SoBHXH { get; set; }
public DateTime? BHXHTuNgay { get; set; }
public DateTime? BHXHDenNgay { get; set; }
public string? SoBHYT { get; set; }
public DateTime? BHYTTuNgay { get; set; }
public DateTime? BHYTDenNgay { get; set; }
public string? MaUngvien { get; set; }
public string? MaTrinhDo { get; set; }
public string? ChuyenMon { get; set; }
public DateTime? NgayThuViec { get; set; }
public DateTime? NgayHetThuViec { get; set; }
public DateTime? NgayThamGiaCM { get; set; }
public DateTime? NgayVaoDoan { get; set; }
public DateTime? NgayVaoDang { get; set; }
public string? MaChucVu { get; set; }
public string? MaChucDanh { get; set; }
public string? SucKhoe { get; set; }
public float? ChieuCao { get; set; }
public float? CanNang { get; set; }
public string? NhomMau { get; set; }
public string? DienThoai { get; set; }
public string? Email { get; set; }
public string? CMND { get; set; }
public string? NoiCap { get; set; }
public DateTime? NgayCap { get; set; }
public string? HonNhan { get; set; }
public DateTime? NgayVaoLam { get; set; }
public DateTime? NgayNghiViec { get; set; }
public string? MaPhongBan { get; set; }
public string? DangLamViec { get; set; }
public string? MaNhom { get; set; }
public string? Didong { get; set; }
public string? Nangkhieu { get; set; }
public string? Ghichu { get; set; }
public string? Congviec { get; set; }
public string? ID { get; set; }
public string? SoSLD { get; set; }
public DateTime? SLDCapNgay { get; set; }
public string? SoQuyetDinh { get; set; }
public string? TienTroCap { get; set; }
public string? LyDoNghi { get; set; }
public string? Dutru1 { get; set; }
public string? Dutru2 { get; set; }
public string? Dutru3 { get; set; }
public string? Dutru4 { get; set; }
public string? Dutru5 { get; set; }
public string? MaSoThue { get; set; }
public int? NamVaoNganhDauKhi { get; set; }
public string? ChungChiTinHoc { get; set; }
public string? TinhThanh { get; set; }
public int? SapXep { get; set; }
public string? MaHopDong { get; set; }
public string? MaTrinhDoQuanLyNN { get; set; }
public DateTime? NgayQuyetDinhNghiViec { get; set; }
public bool? DangVien { get; set; }
public string? MaTrinhDoChinhTri { get; set; }
public string? MaChucVu_BaoCao { get; set; }
public int? NhanVien_Id { get; set; }
public DateTime? MocTinhPhep { get; set; }
public string? TenKhongDau { get; set; }
public int? Trai_Id { get; set; }
public int? SapXep_Trai { get; set; }

        public NS_NHANVIEN()
        {
        }
    }
}

