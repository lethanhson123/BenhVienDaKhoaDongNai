namespace Data_eHospital_DongNai_A.Model
{
    public partial class CDT_KeHoachDaoTao : BaseModel
    {
        [Key]
        public int? CDT_KeHoachDaoTao_Id { get; set; }
public int? KhoaHoc_Id { get; set; }
public int? HocVien_Id { get; set; }
public int? NhanVien_Id { get; set; }
public string? NoiCongTac { get; set; }
public int? KetQua_Id { get; set; }
public string? TenBangCap { get; set; }
public int? XepLoai_Id { get; set; }
public DateTime? NgayTao { get; set; }
public int? NguoiTao_Id { get; set; }
public DateTime? NgayCapNhat { get; set; }
public int? NguoiCapNhat_Id { get; set; }
public string? MaNhanVien_Id { get; set; }
public string? LoaiNhanVien { get; set; }
public string? NoiCapBang { get; set; }
public string? GhiChu { get; set; }

        public CDT_KeHoachDaoTao()
        {
        }
    }
}

