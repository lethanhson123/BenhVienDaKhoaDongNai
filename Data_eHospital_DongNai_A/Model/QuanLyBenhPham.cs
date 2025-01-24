namespace Data_eHospital_DongNai_A.Model
{
    public partial class QuanLyBenhPham : BaseModel
    {
        [Key]
        public int? QuanLyBenhPham_Id { get; set; }
public string? SoPhieu { get; set; }
public int? BenhAn_Id { get; set; }
public int? TiepNhan_Id { get; set; }
public int? NoiThucHien_Id { get; set; }
public DateTime? NgayThucHien { get; set; }
public DateTime? ThoiGianThucHien { get; set; }
public DateTime? ThoiGianTraKQ { get; set; }
public int? KyThuatVien_ID { get; set; }
public int? SoLuongOngMau { get; set; }
public DateTime? ThoiGianLayMau { get; set; }
public int? DungTich { get; set; }
public int? TinhTrangMau_ID { get; set; }
public int? GhiChu { get; set; }
public DateTime? NgayTao { get; set; }
public int? NguoiTao_ID { get; set; }
public DateTime? NgayCapNhat { get; set; }
public int? NguoiCapNhat_Id { get; set; }
public string? KetLuan { get; set; }
public string? GhiChuBenhPham { get; set; }

        public QuanLyBenhPham()
        {
        }
    }
}

