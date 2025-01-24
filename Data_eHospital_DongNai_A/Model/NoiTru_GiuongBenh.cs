namespace Data_eHospital_DongNai_A.Model
{
    public partial class NoiTru_GiuongBenh : BaseModel
    {
        [Key]
        public int? NoiTru_GiuongBenh_Id { get; set; }
public int? LuuTru_Id { get; set; }
public int? LuuTruChiTiet_Id { get; set; }
public DateTime? NgayThu { get; set; }
public DateTime? ThoiGianThu { get; set; }
public decimal? DonGiaDoanhThu { get; set; }
public decimal? DonGiaHoTro { get; set; }
public decimal? DonGiaHoTroChiTra { get; set; }
public decimal? DonGiaThanhToan { get; set; }
public decimal? SoLuong { get; set; }
public decimal? SoTienThucTe { get; set; }
public decimal? SoTienMienGiam { get; set; }
public decimal? SoTienThatThu { get; set; }
public decimal? SoTienConLai { get; set; }
public decimal? SoTienDaThanhToan { get; set; }
public string? DienGiai { get; set; }
public int? NguoiThu { get; set; }
public DateTime? NgayTao { get; set; }
public int? NguoiTao { get; set; }
public DateTime? NgayCapNhat { get; set; }
public int? NguoiCapNhat { get; set; }
public int? LoaiGia_Id { get; set; }
public bool? Huy { get; set; }
public int? DoiTuong_Id { get; set; }
public bool? BaoHiem { get; set; }
public decimal? DonGiaChenhLech { get; set; }
public decimal? DonGiaHoTroChenhLech { get; set; }

        public NoiTru_GiuongBenh()
        {
        }
    }
}

