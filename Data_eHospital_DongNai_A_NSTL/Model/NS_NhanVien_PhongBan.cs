namespace Data_eHospital_DongNai_A_NSTL.Model
{
    public partial class NS_NhanVien_PhongBan : BaseModel
    {
        [Key]
        public int? NS_NhanVien_PhongBan_Id { get; set; }
public string? MaNhanVien { get; set; }
public int? PhongBan_Id { get; set; }

        public NS_NhanVien_PhongBan()
        {
        }
    }
}

