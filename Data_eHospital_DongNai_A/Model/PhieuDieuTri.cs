namespace Data_eHospital_DongNai_A.Model
{
    public partial class PhieuDieuTri : BaseModel
    {
        [Key]
        public int? PhieuDieuTri_Id { get; set; }
public int? BenhNhan_Id { get; set; }
public string? SoPhieuDieuTri { get; set; }
public int? STT { get; set; }
public DateTime? NgayCap { get; set; }
public DateTime? NgayHieuLuc { get; set; }
public DateTime? NgayHetHieuLuc { get; set; }
public bool? TamNgung { get; set; }
public int? NguoiTao_Id { get; set; }
public DateTime? NgayTao { get; set; }
public int? NguoiCapNhat_Id { get; set; }
public DateTime? NgayCapNhat { get; set; }

        public PhieuDieuTri()
        {
        }
    }
}

