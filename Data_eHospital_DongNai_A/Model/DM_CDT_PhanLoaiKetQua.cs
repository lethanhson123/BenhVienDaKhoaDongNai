namespace Data_eHospital_DongNai_A.Model
{
    public partial class DM_CDT_PhanLoaiKetQua : BaseModel
    {
        [Key]
        public int? CDT_PhanLoaiKetQua_Id { get; set; }
public string? MaPhanLoaiKetQua { get; set; }
public string? TenPhanLoaiKetQua { get; set; }
public string? Description { get; set; }
public bool? TamNgung { get; set; }
public int? NguoiTao_Id { get; set; }
public DateTime? NgayTao { get; set; }
public int? NguoiCapNhat_Id { get; set; }
public DateTime? NgayCapNhat { get; set; }

        public DM_CDT_PhanLoaiKetQua()
        {
        }
    }
}

