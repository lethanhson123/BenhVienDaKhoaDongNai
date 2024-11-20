namespace Data.Model
{
    public partial class KhachHang : BaseModel
    {
      
public long? DanhMucTinhThanhID { get; set; }
public string? DanhMucTinhThanhName { get; set; }
public long? DanhMucQuanHuyenID { get; set; }
public string? DanhMucQuanHuyenName { get; set; }
public long? DanhMucXaPhuongID { get; set; }
public string? DanhMucXaPhuongName { get; set; }
public string? DiaChi { get; set; }
public string? HoTen { get; set; }
public int? NamSinh { get; set; }
public DateTime? NgaySinh { get; set; }
public bool? GioiTinh { get; set; }
public string? CCCD { get; set; }
public string? DienThoai { get; set; }
public string? Email { get; set; }
public string? Zalo { get; set; }
public string? BHYT { get; set; }

        public KhachHang()
        {
        }
    }
}

