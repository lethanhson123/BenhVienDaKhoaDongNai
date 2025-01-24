namespace Data_eHospital_DongNai_A.Model
{
    public partial class BenhAnNgoaiTru : BaseModel
    {
        [Key]
        public int? BenhAnNgoaiTru_Id { get; set; }
public string? SoBenhAn { get; set; }
public string? SoLuuTru { get; set; }
public int? LoaiBenhAn_Id { get; set; }
public int? TiepNhan_Id { get; set; }
public int? BenhNhan_Id { get; set; }
public int? KhoaDieuTri_Id { get; set; }
public int? BacSiDieuTri_Id { get; set; }
public DateTime? DieuTriTuNgay { get; set; }
public DateTime? DieuTriDenNgay { get; set; }
public string? QuaTrinhBenhLy { get; set; }
public string? TienSuBanThan { get; set; }
public string? TienSuGiaDinh { get; set; }
public string? KhamToanThan { get; set; }
public string? KhamCacBoPhan { get; set; }
public string? DaXuLy { get; set; }
public int? Mach { get; set; }
public int? HuyetApCao { get; set; }
public int? HuyetApThap { get; set; }
public int? NhipTho { get; set; }
public string? NhietDo { get; set; }
public string? ChieuCao { get; set; }
public string? CanNang { get; set; }
public string? TangNguoi { get; set; }
public int? ICD_NoiGioiThieu { get; set; }
public string? ChanDoanNoiGioiThieu { get; set; }
public int? ICD_KhamBenh { get; set; }
public string? ChanDoanKhamBenh { get; set; }
public int? ICD_BenhChinh { get; set; }
public int? ICD_BenhPhu { get; set; }
public string? ChanDoanRaVien { get; set; }
public DateTime? NgayLapBenhAn { get; set; }
public DateTime? NgayNhapVien { get; set; }
public DateTime? ThoiGianNhapVien { get; set; }
public DateTime? NgayRaVien { get; set; }
public DateTime? ThoiGianRaVien { get; set; }
public int? LyDoNhapVien_Id { get; set; }
public int? LyDoRaVien_Id { get; set; }
public int? KetQuaDieuTri_Id { get; set; }
public string? TinhTrangRaVien { get; set; }
public string? PhuongPhapDieuTri { get; set; }
public string? KeHoachDieuTri { get; set; }
public string? TrangThai { get; set; }
public bool? KhoaBenhAn { get; set; }
public DateTime? NgayTao { get; set; }
public int? NguoiTao_Id { get; set; }
public DateTime? NgayCapNhat { get; set; }
public int? NguoiCapNhat_Id { get; set; }
public int? KeHoachDieuTri_Id { get; set; }
public int? PhuongPhapDieuTri_Id { get; set; }
public string? TangTruong { get; set; }
public string? MucTieuDieuTri { get; set; }
public int? MucTieuDieuTri_Id { get; set; }
public string? HuongDieuTriRaVien { get; set; }
public string? XetNghiem { get; set; }
public int? ChuyenDenBenhVien_Id { get; set; }
public int? ChuyenVien_Id { get; set; }

        public BenhAnNgoaiTru()
        {
        }
    }
}

