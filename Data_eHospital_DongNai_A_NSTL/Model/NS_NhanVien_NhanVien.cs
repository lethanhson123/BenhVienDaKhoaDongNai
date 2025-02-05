namespace Data_eHospital_DongNai_A_NSTL.Model
{
    public partial class NS_NhanVien_NhanVien : BaseModel
    {
        [Key]
        public int? NS_NhanVien_NhanVien_ID { get; set; }
public int? NhanVien_Id { get; set; }
public int? NhanVienQL_Id { get; set; }
public string? MaNhanVien { get; set; }
public string? MaNhanVienQL { get; set; }
public string? GhiChu { get; set; }

        public NS_NhanVien_NhanVien()
        {
        }
    }
}

