namespace Data_eHospital_DongNai_A.Model
{
    public partial class NhanVien_KSK_NgoaiVien : BaseModel
    {
        [Key]
        public int? NhanVien_KSK_Id { get; set; }
public string? MaNhanVien { get; set; }
public string? MaDotKSK { get; set; }
public int? KSK_NgoaiVien_Id { get; set; }

        public NhanVien_KSK_NgoaiVien()
        {
        }
    }
}

