namespace Data_eHospital_DongNai_A.Model
{
    public partial class DM_PhacDoDieuTri : BaseModel
    {
        [Key]
        public int? PhacDoDieuTri_Id { get; set; }
public string? MaPhacDo { get; set; }
public string? TenPhacDo { get; set; }
public int? ICD_Id { get; set; }
public int? ChuyenKhoa_Id { get; set; }
public bool? TamNgung { get; set; }
public string? GhiChu { get; set; }
public DateTime? NgayTao { get; set; }
public int? NguoiTao_Id { get; set; }
public DateTime? NgayCapNhat { get; set; }
public int? NguoiCapNhat_Id { get; set; }

        public DM_PhacDoDieuTri()
        {
        }
    }
}

