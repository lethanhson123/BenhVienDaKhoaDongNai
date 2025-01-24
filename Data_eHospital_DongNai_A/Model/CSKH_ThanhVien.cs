namespace Data_eHospital_DongNai_A.Model
{
    public partial class CSKH_ThanhVien : BaseModel
    {
        [Key]
        public int? ThanhVien_Id { get; set; }
public string? MaThanhVien { get; set; }
public int? BenhNhan_Id { get; set; }
public bool? TamNgung { get; set; }
public bool? DaXoa { get; set; }
public DateTime? NgayTao { get; set; }
public int? NguoiTao_Id { get; set; }
public DateTime? NgayCapNhat { get; set; }
public int? NguoiCapNhat_Id { get; set; }
public int? Attribute_1 { get; set; }
public int? Attribute_2 { get; set; }
public string? Attribute_3 { get; set; }
public string? Attribute_4 { get; set; }
public bool? Attribute_5 { get; set; }
public bool? Attribute_6 { get; set; }
public DateTime? NgayDangKy { get; set; }
public bool? DaThuTien { get; set; }
public int? Id_Cu { get; set; }
public DateTime? NgayTaoHoiVien { get; set; }
public int? NoiChiDinh_Id { get; set; }
public int? BacSiChiDinh_Id { get; set; }
public string? DonGiaDoanhThu { get; set; }
public string? DonGiaHoTro { get; set; }
public string? DonGiaHoTroChiTra { get; set; }
public string? DonGiaThanhToan { get; set; }
public string? GiaTriMienGiam { get; set; }
public string? GiaTriThatThu { get; set; }
public string? GiaTriDaThanhToan { get; set; }

        public CSKH_ThanhVien()
        {
        }
    }
}

