namespace Data_eHospital_DongNai_A.Model
{
    public partial class CDT_PhanCongDeAn_1816 : BaseModel
    {
        [Key]
        public int? CDT_PhanCong_Id { get; set; }
public int? KeHoach_Id { get; set; }
public int? NhanVien_Id { get; set; }
public DateTime? NgayThamGia { get; set; }
public DateTime? NgayKetThuc { get; set; }
public string? KetQua { get; set; }
public DateTime? NgayTao { get; set; }
public int? NguoiTao_Id { get; set; }
public DateTime? NgayCapNhat { get; set; }
public int? NguoiCapNhat_Id { get; set; }
public string? MaNhanVien_Id { get; set; }
public string? LoaiNhanVien { get; set; }
public int? NhanVien_Id_TD { get; set; }
public string? GhiChu { get; set; }

        public CDT_PhanCongDeAn_1816()
        {
        }
    }
}

