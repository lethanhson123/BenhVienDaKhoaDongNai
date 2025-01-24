namespace Data_eHospital_DongNai_A.Model
{
    public partial class KSK_HopDong_BenhNhan : BaseModel
    {
        [Key]
        public int? BenhNhan_Id { get; set; }
public int? HopDong_id { get; set; }
public int? Benhnhan_ehos_id { get; set; }
public string? MaYTe { get; set; }
public int? STT { get; set; }
public string? TenBenhNhan { get; set; }
public string? Ho { get; set; }
public string? Ten { get; set; }
public string? GioiTinh { get; set; }
public DateTime? NgaySinh { get; set; }
public int? NamSinh { get; set; }
public string? DiaChi { get; set; }
public int? NhomMau_Id { get; set; }
public int? YeuToRH_Id { get; set; }
public string? TienSuDiUng { get; set; }
public string? SoLuuTruNgoaiTru { get; set; }
public string? SoLuuTruNoiTru { get; set; }
public bool? TuVong { get; set; }
public string? GhiChu { get; set; }
public int? QuocTich_Id { get; set; }
public int? TinhThanh_Id { get; set; }
public int? QuanHuyen_Id { get; set; }
public int? XaPhuong_Id { get; set; }
public int? DanToc_Id { get; set; }
public int? NgheNghiep_Id { get; set; }
public string? CMND { get; set; }
public string? HoChieu { get; set; }
public string? TenKhongDau { get; set; }
public DateTime? NgayTao { get; set; }
public int? NguoiTao_Id { get; set; }
public DateTime? NgayCapNhat { get; set; }
public int? NguoiCapNhat_Id { get; set; }
public string? SoDienThoai { get; set; }
public string? KetQua { get; set; }
public DateTime? NgayCapThe { get; set; }
public int? NamCapThe { get; set; }
public int? NhanVien_Id { get; set; }
public string? TienSuBenh { get; set; }
public string? TienSuHutThuocLa { get; set; }
public int? DonViCongTac_Id { get; set; }
public string? SoDienThoai1 { get; set; }
public DateTime? NgayTiepNhanGanNhat { get; set; }
public DateTime? ThoiGianTiepNhanGanNhat { get; set; }
public int? Xeploai_id { get; set; }
public int? bsketluan_id { get; set; }
public int? tinhtranghonnhan_id { get; set; }
public int? NhomDoiTuong_Id { get; set; }
public int? ChuyenChungTuID { get; set; }
public int? ChuyenChungTu_HoaDonID { get; set; }
public int? IDChuyen { get; set; }
public DateTime? NgayHen { get; set; }
public int? Mach { get; set; }
public int? HuyetApThap { get; set; }
public int? HuyetApCao { get; set; }
public int? NhipTho { get; set; }
public decimal? NhietDo { get; set; }
public decimal? ChieuCao { get; set; }
public decimal? CanNang { get; set; }
public decimal? BMI { get; set; }
public string? Mat_KhongKinh_Phai { get; set; }
public string? Mat_KhongKinh_Trai { get; set; }
public string? Mat_CoKinh_Phai { get; set; }
public string? Mat_CoKinh_Trai { get; set; }
public string? Mat_CacBenhVeMat { get; set; }
public string? TMH_TaiTrai_NoiThuong { get; set; }
public string? TMH_TaiTrai_NoiTham { get; set; }
public string? TMH_TaiPhai_NoiThuong { get; set; }
public string? TMH_TaiPhai_NoiTham { get; set; }
public string? TMH_CacBenhVeTMH { get; set; }
public string? RHM_HamTren { get; set; }
public string? RHM_HamDuoi { get; set; }
public string? RHM_CacBenhVeRHM { get; set; }
public string? MaNhanVien { get; set; }
public string? DonVi_BoPhan { get; set; }

        public KSK_HopDong_BenhNhan()
        {
        }
    }
}

