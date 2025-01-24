namespace Data_eHospital_DongNai_A.Model
{
    public partial class KhamGayMe : BaseModel
    {
        [Key]
        public int? KhamGayMe_Id { get; set; }
public int? TiepNhan_Id { get; set; }
public int? BenhAn_Id { get; set; }
public int? CLSYeuCau_Id { get; set; }
public DateTime? NgayKham { get; set; }
public DateTime? ThoiGianKham { get; set; }
public int? NguoiKham_Id { get; set; }
public DateTime? ThoiGianMoDuKien { get; set; }
public int? PhongMoDuKien_Id { get; set; }
public string? GhiChu { get; set; }
public string? DeNghi { get; set; }
public string? KetLuan { get; set; }
public string? TienSu { get; set; }
public string? TienSu_Text { get; set; }
public string? YeuCauKham { get; set; }
public string? YeuCauKham_Text { get; set; }
public string? BenhSu { get; set; }
public string? BenhSu_Text { get; set; }
public string? NhanXet { get; set; }
public string? NhanXet_Text { get; set; }
public bool? Khoa { get; set; }
public DateTime? NgayKhoa { get; set; }
public int? NguoiKhoa_Id { get; set; }
public DateTime? NgayTao { get; set; }
public int? NguoiTao_Id { get; set; }
public DateTime? NgayCapNhat { get; set; }
public int? NguoiCapNhat_Id { get; set; }

        public KhamGayMe()
        {
        }
    }
}

