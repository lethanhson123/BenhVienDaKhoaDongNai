namespace Data_eHospital_DongNai_A.Model
{
    public partial class KSK_Congty : BaseModel
    {
        [Key]
        public int? Congty_Id { get; set; }
public string? MaCongty { get; set; }
public string? TenCongty { get; set; }
public string? TenCongty_En { get; set; }
public string? TenCongty_Ru { get; set; }
public string? DiaChi { get; set; }
public string? DienThoai { get; set; }
public string? Fax { get; set; }
public string? Email { get; set; }
public string? MaSoThue { get; set; }
public string? GiamDoc { get; set; }
public string? NguoiLienHe { get; set; }
public bool? NuocNgoai { get; set; }
public bool? NhaNuoc { get; set; }
public bool? TamNgung { get; set; }
public string? TenKhongDau { get; set; }
public DateTime? NgayTao { get; set; }
public int? NguoiTao_Id { get; set; }
public DateTime? NgayCapNhat { get; set; }
public int? NguoiCapNhat_Id { get; set; }
public string? HeSo { get; set; }

        public KSK_Congty()
        {
        }
    }
}

