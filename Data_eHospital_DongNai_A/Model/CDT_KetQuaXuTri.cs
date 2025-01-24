namespace Data_eHospital_DongNai_A.Model
{
    public partial class CDT_KetQuaXuTri : BaseModel
    {
        [Key]
        public int? CDT_KetQua_Id { get; set; }
public int? TiepNhan_Id { get; set; }
public int? BenhNhan_Id { get; set; }
public string? KetQuaXuTri { get; set; }
public bool? XuTriDacBiet { get; set; }
public bool? TamNgung { get; set; }
public DateTime? NgayTao { get; set; }
public int? NguoiTao_Id { get; set; }
public DateTime? NgayCapNhat { get; set; }
public int? NguoiCapNhat_Id { get; set; }
public string? ChanDoanTuyenDuoi { get; set; }
public string? XuTriTuyenDuoi { get; set; }
public string? ChanDoanBenhVien { get; set; }
public string? XuTriBenhVien { get; set; }

        public CDT_KetQuaXuTri()
        {
        }
    }
}

