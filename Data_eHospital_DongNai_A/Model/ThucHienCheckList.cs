namespace Data_eHospital_DongNai_A.Model
{
    public partial class ThucHienCheckList : BaseModel
    {
        [Key]
        public int? ThucHienCheckList_Id { get; set; }
public int? BenhNhan_Id { get; set; }
public int? TiepNhan_Id { get; set; }
public int? BenhAn_Id { get; set; }
public int? NhanVienThucHien_Id { get; set; }
public DateTime? NgayThucHien { get; set; }
public int? NhanVienCapNhat_Id { get; set; }
public DateTime? NgayNhanVienCapNhat { get; set; }
public int? NhanVienKiemTra_Id { get; set; }
public DateTime? NgayKiemTra { get; set; }
public int? NguoiTao_Id { get; set; }
public DateTime? NgayTao { get; set; }
public int? NguoiCapNhat_Id { get; set; }
public DateTime? NgayCapNhat { get; set; }
public string? GhiChu { get; set; }
public DateTime? ThoiGianThucHien { get; set; }
public DateTime? ThoiGianKiemTra { get; set; }
public DateTime? NgayLuu { get; set; }
public DateTime? ThoiGianLuu { get; set; }
public int? MauCheckList_Id { get; set; }

        public ThucHienCheckList()
        {
        }
    }
}

