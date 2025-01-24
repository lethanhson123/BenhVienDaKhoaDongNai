namespace Data_eHospital_DongNai_A.Model
{
    public partial class CDT_KSK_TuyenDuoi : BaseModel
    {
        [Key]
        public int? KSK_TuyenDuoi_Id { get; set; }
public int? BenhVien_Id { get; set; }
public string? MaDotKSK { get; set; }
public string? TenDotKSK { get; set; }
public DateTime? TuNgay { get; set; }
public DateTime? DenNgay { get; set; }
public string? DiaDiem { get; set; }
public DateTime? NgayTao { get; set; }
public int? NguoiTao_Id { get; set; }
public DateTime? NgayCapNhat { get; set; }
public int? NguoiCapNhat_Id { get; set; }

        public CDT_KSK_TuyenDuoi()
        {
        }
    }
}

