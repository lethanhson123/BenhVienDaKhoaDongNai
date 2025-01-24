namespace Data_eHospital_DongNai_A.Model
{
    public partial class CSKH_DM_LoaiKhachHang : BaseModel
    {
        [Key]
        public int? LoaiKhachHang_Id { get; set; }
public string? MaLoaiKhachHang { get; set; }
public string? TenLoaiKhachHang { get; set; }
public string? GhiChu { get; set; }
public int? TuoiMin { get; set; }
public int? TuoiMax { get; set; }
public decimal? SoTien { get; set; }
public string? TienTe_Id { get; set; }
public bool? IsThanhVien { get; set; }
public bool? AppNam { get; set; }
public bool? AppNguoi { get; set; }
public bool? TamNgung { get; set; }
public DateTime? NgayTao { get; set; }
public int? NguoiTao_Id { get; set; }
public DateTime? NgayCapNhat { get; set; }
public int? NguoiCapNhat_Id { get; set; }
public bool? IsTheVinMec { get; set; }
public bool? CoThuTien { get; set; }
public int? DonViPhatHanh_Id { get; set; }
public int? NhomLoaiHoiVien_Id { get; set; }
public string? Prefixcode { get; set; }

        public CSKH_DM_LoaiKhachHang()
        {
        }
    }
}

