namespace Data_eHospital_DongNai_A.Model
{
    public partial class TomTatHoSoBenhAn : BaseModel
    {
        [Key]
        public int? TomTatHoSoBenhAn_Id { get; set; }
public string? SoPhieuTomTat { get; set; }
public int? BenhAn_Id { get; set; }
public int? BenhNhan_Id { get; set; }
public int? LoaiKCB_Id { get; set; }
public string? HoTenCha { get; set; }
public string? HoTenMe { get; set; }
public string? NguoiGiamHo { get; set; }
public string? MaDonVi { get; set; }
public string? TenDonVi { get; set; }
public string? DiaChiDonVi { get; set; }
public string? ChanDoanVaoVien { get; set; }
public string? ChanDoanRaVien { get; set; }
public string? QuaTrinhBenhLy { get; set; }
public string? TomTatKetQua { get; set; }
public string? PhuongPhapDieuTri { get; set; }
public DateTime? NgaySinhCon { get; set; }
public DateTime? NgayConChet { get; set; }
public int? SoConChet { get; set; }
public string? GhiChu { get; set; }
public int? ThuTruongDonVi_Id { get; set; }
public string? MaTheTam { get; set; }
public string? DuPhong { get; set; }
public DateTime? NgayTao { get; set; }
public int? NguoiTao_Id { get; set; }
public DateTime? NgayCapNhat { get; set; }
public int? NguoiCapNhat_Id { get; set; }
public int? BenhAnNgoaiTru_Id { get; set; }
public int? LanhDaoKhoa_Id { get; set; }
public int? NguoiLap_Id { get; set; }

        public TomTatHoSoBenhAn()
        {
        }
    }
}

