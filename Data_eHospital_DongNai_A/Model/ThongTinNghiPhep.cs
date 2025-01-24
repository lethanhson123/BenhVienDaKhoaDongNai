namespace Data_eHospital_DongNai_A.Model
{
    public partial class ThongTinNghiPhep : BaseModel
    {
        [Key]
        public int? NghiPhep_Id { get; set; }
public string? SoPhieu { get; set; }
public int? LoaiPhieu_Id { get; set; }
public string? SoSeri { get; set; }
public string? SoKCB { get; set; }
public int? BenhNhan_Id { get; set; }
public int? TiepNhan_Id { get; set; }
public int? KhamBenh_Id { get; set; }
public int? BenhAnNoiTru_Id { get; set; }
public int? BenhAnNgoaiTru_Id { get; set; }
public int? BacSiYeuCau_Id { get; set; }
public int? BacSiTruongKhoa_Id { get; set; }
public int? BenhVien_Id { get; set; }
public int? LyDoNghiPhep_Id { get; set; }
public DateTime? NghiTu { get; set; }
public DateTime? NghiDen { get; set; }
public int? SoNgayNghi { get; set; }
public string? SoBHXH { get; set; }
public string? SoBHYT { get; set; }
public string? HoTenCha { get; set; }
public string? HoTenMe { get; set; }
public string? MaTheTam { get; set; }
public string? MaDonVi { get; set; }
public string? TenDonVi { get; set; }
public string? DiaChiDonVi { get; set; }
public int? ChanDoanICD_Id { get; set; }
public string? ChanDoanRaVien { get; set; }
public string? PhuongPhapDieuTri { get; set; }
public bool? DinhChiThaiNghen { get; set; }
public string? DinhChiThaiNghen_NguyenNhan { get; set; }
public int? DinhChiThaiNghen_TuoiThai { get; set; }
public string? GhiChu { get; set; }
public int? ThuTruongDonVi_Id { get; set; }
public int? NguoiDuyet_Id { get; set; }
public DateTime? NgayDuyet { get; set; }
public DateTime? NgayCapNhatDuyet { get; set; }
public bool? DaDuyet { get; set; }
public int? NguoiHuy_Id { get; set; }
public DateTime? NgayHuy { get; set; }
public bool? DaHuy { get; set; }
public DateTime? NgayRaPhieu { get; set; }
public DateTime? NgayTao { get; set; }
public int? NguoiTao_Id { get; set; }
public DateTime? NgayCapNhat { get; set; }
public int? NguoiCapNhat_Id { get; set; }
public string? Attribute1 { get; set; }
public string? Attribute2 { get; set; }
public string? Attribute3 { get; set; }
public string? Attribute4 { get; set; }
public string? Attribute5 { get; set; }
public decimal? Attribute6 { get; set; }
public decimal? Attribute7 { get; set; }
public decimal? Attribute8 { get; set; }
public DateTime? Attribute9 { get; set; }
public DateTime? Attribute10 { get; set; }
public DateTime? Attribute11 { get; set; }
public DateTime? Attribute12 { get; set; }

        public ThongTinNghiPhep()
        {
        }
    }
}

