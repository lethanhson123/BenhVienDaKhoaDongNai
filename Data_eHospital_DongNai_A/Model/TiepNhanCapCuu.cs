namespace Data_eHospital_DongNai_A.Model
{
    public partial class TiepNhanCapCuu : BaseModel
    {
        [Key]
        public int? TiepNhanCapCuu_Id { get; set; }
public int? TiepNhan_Id { get; set; }
public int? BenhNhan_Id { get; set; }
public string? NoiLamViec { get; set; }
public string? DienThoaiNLV { get; set; }
public string? NguoiThan { get; set; }
public string? DienThoaiNT { get; set; }
public string? NoiDuaDen { get; set; }
public string? DienThoaiNDD { get; set; }
public DateTime? NgayTaiNan { get; set; }
public DateTime? ThoiGianTaiNan { get; set; }
public DateTime? NgayCapCuu { get; set; }
public DateTime? ThoiGianCapCuu { get; set; }
public DateTime? NgayKhamBenh { get; set; }
public DateTime? ThoiGianKhamBenh { get; set; }
public int? NoiBiTaiNan_Id { get; set; }
public int? TinhThanh_Id { get; set; }
public int? QuanHuyen_Id { get; set; }
public int? PhuongXa_Id { get; set; }
public string? DiaChi { get; set; }
public int? DienBienSauTN_Id { get; set; }
public int? NguyenNhan_Id { get; set; }
public int? NguyenNhan_ICD { get; set; }
public int? NguyenNhanChiTiet_Id { get; set; }
public int? ThuongTich_Id { get; set; }
public int? MucDo_Id { get; set; }
public string? ChiTietCapCuu { get; set; }
public DateTime? NgayRa { get; set; }
public DateTime? ThoiGianRa { get; set; }
public string? HoiChan { get; set; }
public string? TinhHinhXuat { get; set; }
public int? SoNgayNghi { get; set; }
public int? MatSuc { get; set; }
public int? KhoaNhap_Id { get; set; }
public int? ChuyenVien_Id { get; set; }
public string? BenhSu { get; set; }
public int? Mach { get; set; }
public int? NhipTho { get; set; }
public decimal? NhietDo { get; set; }
public decimal? CanNang { get; set; }
public string? HuyetAp { get; set; }
public int? HuyetApCao { get; set; }
public int? HuyetApThap { get; set; }
public decimal? ChieuCao { get; set; }
public int? KetQuaDieuTri_Id { get; set; }
public int? NhapKhoa_Id { get; set; }
public string? TienSuBenh { get; set; }
public string? CanLamSang { get; set; }
public string? ChanDoanLucVao { get; set; }
public int? ICD_Vao_Id { get; set; }
public string? ChanDoanLucRa { get; set; }
public int? ICD_Ra_Id { get; set; }
public string? XuTri { get; set; }
public DateTime? NgayTao { get; set; }
public int? NguoiTao_Id { get; set; }
public DateTime? NgayCapNhat { get; set; }
public int? NguoiCapNhat_Id { get; set; }
public bool? TuVong { get; set; }
public DateTime? NgayTuVong { get; set; }
public DateTime? ThoiGianTuVong { get; set; }
public DateTime? ThoiGianKhamNghiem { get; set; }
public DateTime? ThoiGianNhanTuThi { get; set; }
public string? KetQuaKhamNghiem { get; set; }
public string? GhiChu { get; set; }
public int? ICD_TuVong_Id { get; set; }
public int? BacSiGhiNhanTuVong_Id { get; set; }
public int? BacSiKhamNghiem_Id { get; set; }

        public TiepNhanCapCuu()
        {
        }
    }
}

