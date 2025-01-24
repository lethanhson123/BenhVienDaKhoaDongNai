namespace Data_eHospital_DongNai_A.Model
{
    public partial class CSKH_The : BaseModel
    {
        [Key]
        public int? The_Id { get; set; }
public string? MaThe { get; set; }
public string? MaDKThe { get; set; }
public int? TaiKhoan_Id { get; set; }
public int? ThanhVien_Id { get; set; }
public int? LoaiKhachHang_Id { get; set; }
public bool? KickHoat { get; set; }
public bool? TamNgung { get; set; }
public int? HopDong_Id { get; set; }
public DateTime? NgayTao { get; set; }
public int? NguoiTao_Id { get; set; }
public DateTime? NgayCapNhat { get; set; }
public int? NguoiCapNhat_Id { get; set; }
public string? Attribute_1 { get; set; }
public string? Attribute_2 { get; set; }
public string? Attribute_3 { get; set; }
public bool? Attribute_4 { get; set; }
public bool? Attribute_5 { get; set; }
public int? Attribute_6 { get; set; }
public int? Attribute_7 { get; set; }
public decimal? Attribute_8 { get; set; }
public bool? Phu { get; set; }

        public CSKH_The()
        {
        }
    }
}

