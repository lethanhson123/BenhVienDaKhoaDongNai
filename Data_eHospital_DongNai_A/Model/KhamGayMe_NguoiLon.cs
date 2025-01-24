namespace Data_eHospital_DongNai_A.Model
{
    public partial class KhamGayMe_NguoiLon : BaseModel
    {
        [Key]
        public int? KhamGayMe_NguoiLon_Id { get; set; }
public string? SoPhieuGayMe { get; set; }
public int? BenhNhan_Id { get; set; }
public int? TiepNhan_Id { get; set; }
public int? BenhAn_Id { get; set; }
public int? CLSYeuCau_Id { get; set; }
public DateTime? NgayThucHien { get; set; }
public DateTime? ThoiGianThuchien { get; set; }
public int? BacSiGayMe_Id { get; set; }
public decimal? ChieuCao { get; set; }
public decimal? CanNang { get; set; }
public string? ASA { get; set; }
public string? Mallampati { get; set; }
public decimal? KCCamGiap { get; set; }
public decimal? HaMieng { get; set; }
public string? TinhTrangRang { get; set; }
public string? BuaAnCuoiTruocMo { get; set; }
public string? ThoiGianBuaAn { get; set; }
public bool? CapCuu { get; set; }
public bool? DaDayDay { get; set; }
public string? ChanDoan { get; set; }
public string? HuongXuTri { get; set; }
public string? TienSuNoiKhoa { get; set; }
public string? TiensuNgoaikhoa { get; set; }
public string? TienSuGayMeGayTe { get; set; }
public string? DiUng { get; set; }
public bool? ThuocLa { get; set; }
public bool? Ruou { get; set; }
public bool? MaTuy { get; set; }
public string? BenhLayNhiem { get; set; }
public string? ThuocDangDieuTri { get; set; }
public string? KhamLamSang { get; set; }
public string? TuanHoan { get; set; }
public string? M { get; set; }
public string? HA { get; set; }
public string? HoHap { get; set; }
public string? ThanKinh { get; set; }
public string? CotSong { get; set; }
public string? XetNghiemBatThuong { get; set; }
public string? YeuCauBoSung { get; set; }
public string? DuKienThuoc_VoCam { get; set; }
public string? DuKienGiamDauSauMo { get; set; }
public string? YLenhTruocMo_ThuocTienGayMe { get; set; }
public DateTime? NgayTao { get; set; }
public int? NguoiTao_Id { get; set; }
public DateTime? NgayCapNhat { get; set; }
public int? NguoiCapNhat_Id { get; set; }

        public KhamGayMe_NguoiLon()
        {
        }
    }
}

