namespace Data_eHospital_DongNai_A.Model
{
    public partial class GiayRaVien : BaseModel
    {
        [Key]
        public int? GiayRaVien_Id { get; set; }
public string? SoPhieuRaVien { get; set; }
public int? BenhAn_Id { get; set; }
public int? BenhNhan_Id { get; set; }
public string? ChanDoanRaVien { get; set; }
public string? PhuongPhapDieuTri { get; set; }
public bool? DinhChiThaiNghen { get; set; }
public string? DinhChiThaiNghen_NguyenNhan { get; set; }
public int? DinhChiThaiNghen_TuoiThai { get; set; }
public DateTime? DinhChiThaiNghen_ThoiGian { get; set; }
public string? SoBHXHCha { get; set; }
public string? HoTenCha { get; set; }
public string? SoBHXHMe { get; set; }
public string? HoTenMe { get; set; }
public string? MaTheTam { get; set; }
public int? ThuTruongDonVi_Id { get; set; }
public int? LanhDaoKhoa_Id { get; set; }
public int? SoNgayNghi { get; set; }
public DateTime? NghiTuNgay { get; set; }
public DateTime? NghiDenNgay { get; set; }
public string? GhiChu { get; set; }
public DateTime? NgayTao { get; set; }
public int? NguoiTao_Id { get; set; }
public DateTime? NgayCapNhat { get; set; }
public int? NguoiCapNhat_Id { get; set; }
public string? SoSeri { get; set; }
public int? BenhAnNgoaiTru_Id { get; set; }

        public GiayRaVien()
        {
        }
    }
}

