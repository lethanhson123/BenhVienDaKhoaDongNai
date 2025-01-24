namespace Data_eHospital_DongNai_A.Model
{
    public partial class ThongTinKhamSucKhoe : BaseModel
    {
        [Key]
        public int? KhamSucKhoe_Id { get; set; }
public string? SoPhieu { get; set; }
public int? BenhNhan_Id { get; set; }
public int? TiepNhan_Id { get; set; }
public int? HopDong_BenhNhan_Id { get; set; }
public DateTime? NgayKham { get; set; }
public string? TienSu { get; set; }
public decimal? ChieuCao { get; set; }
public decimal? CanNang { get; set; }
public int? NhipTho { get; set; }
public decimal? BMI { get; set; }
public int? Mach { get; set; }
public int? HuyetApCao { get; set; }
public int? HuyetApThap { get; set; }
public decimal? NhietDo { get; set; }
public int? TheLucPhanLoai_Id { get; set; }
public string? TuanHoan { get; set; }
public string? HoHap { get; set; }
public string? TieuHoa { get; set; }
public string? ThanTietNieu { get; set; }
public string? NoiTiet { get; set; }
public string? CoXuongKhop { get; set; }
public string? ThanKinh { get; set; }
public string? TamThan { get; set; }
public int? TuanHoanPhanLoai_Id { get; set; }
public int? HoHapPhanLoai_Id { get; set; }
public int? TieuHoaPhanLoai_Id { get; set; }
public int? ThanTietNieuPhanLoai_Id { get; set; }
public int? NoiTietPhanLoai_Id { get; set; }
public int? CoXuongKhopPhanLoai_Id { get; set; }
public int? ThanKinhPhanLoai_Id { get; set; }
public int? TamThanPhanLoai_Id { get; set; }
public string? Mat { get; set; }
public int? MatPhanLoai_Id { get; set; }
public string? ThiLucTraiCoKinh { get; set; }
public string? ThiLucPhaiCoKinh { get; set; }
public string? ThiLucTraiKhongKinh { get; set; }
public string? ThiLucPhaiKhongKinh { get; set; }
public string? TMH { get; set; }
public int? TMHPhanLoai_Id { get; set; }
public string? TaiTraiNoiThuong { get; set; }
public string? TaiPhaiNoiThuong { get; set; }
public string? TaiTraiNoiTham { get; set; }
public string? TaiPhaiNoiTham { get; set; }
public string? RHM { get; set; }
public int? RHMPhanLoai_Id { get; set; }
public string? RHM_HamTren { get; set; }
public string? RHM_HamDuoi { get; set; }
public string? DaLieu { get; set; }
public int? DaLieuPhanLoai_Id { get; set; }
public string? CanLamSangKetQua { get; set; }
public string? CanLamSangDanhGia { get; set; }
public int? SucKhoePhanLoai_Id { get; set; }
public string? ThongTinBenhTat { get; set; }
public int? BacSiNoi_Id { get; set; }
public int? BacSiMat_Id { get; set; }
public int? BacSiTMH_Id { get; set; }
public int? BacSiRHM_Id { get; set; }
public int? BacSiCXK_Id { get; set; }
public int? BacSiDaLieu_Id { get; set; }
public int? BacSiCLS1_Id { get; set; }
public int? BacSiCLS2_Id { get; set; }
public int? BacSiKetLuan_Id { get; set; }
public int? KhamBenhNoi_Id { get; set; }
public int? KhamBenhMat_Id { get; set; }
public int? KhamBenhTMH_Id { get; set; }
public int? KhamBenhRHM_Id { get; set; }
public int? KhamBenhDaLieu_Id { get; set; }
public DateTime? NgayTao { get; set; }
public int? NguoiTao_Id { get; set; }
public DateTime? NgayCapNhat { get; set; }
public int? NguoiCapNhat_Id { get; set; }
public string? Loai { get; set; }
public string? HoTen { get; set; }
public DateTime? NgaySinh { get; set; }
public int? TinhThanh_Id { get; set; }
public int? QuanHuyen_Id { get; set; }
public int? PhuongXa_Id { get; set; }
public string? DiaChiThuongTru { get; set; }
public string? CCCD { get; set; }
public DateTime? CCCD_NgayCap { get; set; }
public string? CCCD_NoiCap { get; set; }
public int? LX_HangBangLai { get; set; }
public decimal? LX_NongDoCon { get; set; }
public int? LX_DViNongDoCon { get; set; }
public int? LX_MaTuy { get; set; }
public DateTime? LX_NgayKetLuan { get; set; }
public int? LX_KetLuan { get; set; }
public DateTime? LX_NgayKhamLai { get; set; }
public string? LX_LyDo { get; set; }
public string? LX_TinhTrangBenh { get; set; }
public string? ThaiSan { get; set; }
public int? ThaiSanPhanLoai_Id { get; set; }
public int? BacSiThaiSan_Id { get; set; }

        public ThongTinKhamSucKhoe()
        {
        }
    }
}

