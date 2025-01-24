namespace Data_eHospital_DongNai_A.Model
{
    public partial class CDT_DieuTriTuyenDuoi : BaseModel
    {
        [Key]
        public int? CDT_DieuTri_Id { get; set; }
public int? BenhVien_Id { get; set; }
public DateTime? ThoiGianKham { get; set; }
public int? SoCaKham { get; set; }
public int? SoCaICD { get; set; }
public int? SoCaNgoaiTru { get; set; }
public int? SoCaNoiTru { get; set; }
public int? SoCaChuyenVien { get; set; }
public DateTime? NgayTao { get; set; }
public int? NguoiTao_Id { get; set; }
public DateTime? NgayCapNhat { get; set; }
public int? NguoiCapNhat_Id { get; set; }
public string? MaICD { get; set; }
public int? SoCaPhauThuat { get; set; }
public int? SoCaThuThuat { get; set; }
public int? SoCaTuVong { get; set; }
public string? GhiChu { get; set; }

        public CDT_DieuTriTuyenDuoi()
        {
        }
    }
}

