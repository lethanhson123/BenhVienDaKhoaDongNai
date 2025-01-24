namespace Data_eHospital_DongNai_A.Model
{
    public partial class KSK_HopDong : BaseModel
    {
        [Key]
        public int? HopDong_ID { get; set; }
public int? Congty_id { get; set; }
public string? So_HD { get; set; }
public DateTime? Ngay_HD { get; set; }
public decimal? GiaTri_HD { get; set; }
public DateTime? NgayHieuLuc_HD { get; set; }
public DateTime? NgayHetHieuLuc_HD { get; set; }
public int? TrangThai_HD { get; set; }
public decimal? Soluong_BN { get; set; }
public int? Loai_HD { get; set; }
public int? HinhThucThanhToan_PhatSinh { get; set; }
public decimal? GiaTri_TamUng { get; set; }
public decimal? GiaTri_PhatSinh { get; set; }
public string? DienGiai { get; set; }
public DateTime? ThoiGiankham { get; set; }
public DateTime? ThoiGianLayMau { get; set; }
public DateTime? NgayTao { get; set; }
public int? NguoiTao_Id { get; set; }
public DateTime? NgayCapNhat { get; set; }
public int? NguoiCapNhat_Id { get; set; }
public decimal? TyLeChietKhau { get; set; }
public decimal? GiaTriChietKhau { get; set; }
public decimal? TienChiNhanVien { get; set; }

        public KSK_HopDong()
        {
        }
    }
}

