namespace Data_eHospital_DongNai_A_Dictionary.Model
{
    public partial class DM_DoiTuong : BaseModel
    {
        [Key]
        public int? DoiTuong_Id { get; set; }
public string? MaDoiTuong { get; set; }
public int? NhomDoiTuong_Id { get; set; }
public string? TenDoiTuong { get; set; }
public string? TenDoiTuong_En { get; set; }
public string? TenDoiTuong_Ru { get; set; }
public bool? MienPhi { get; set; }
public string? TyLeGiam { get; set; }
public DateTime? NgayNhap { get; set; }
public DateTime? NgayHieuLuc { get; set; }
public DateTime? NgayHetHieuLuc { get; set; }
public bool? TamNgung { get; set; }
public string? GhiChu { get; set; }
public string? TenKhongDau { get; set; }
public DateTime? NgayTao { get; set; }
public int? NguoiTao_Id { get; set; }
public DateTime? NgayCapNhat { get; set; }
public int? NguoiCapNhat_Id { get; set; }
public bool? Booking_Duoc { get; set; }
public int? Booking_KhoDuoc_Id { get; set; }
public decimal? GioiHan_1 { get; set; }
public decimal? TyLe_1 { get; set; }
public decimal? GioiHan_2 { get; set; }
public decimal? TyLe_2 { get; set; }
public decimal? GioiHan_3 { get; set; }
public decimal? TyLe_3 { get; set; }
public decimal? GioiHan_4 { get; set; }
public decimal? TyLe_4 { get; set; }
public string? SiteCode { get; set; }
public int? Mapping_Public_Id { get; set; }
public bool? GiaBanCoLoi { get; set; }
public decimal? MucHuongKTC { get; set; }

        public DM_DoiTuong()
        {
        }
    }
}

