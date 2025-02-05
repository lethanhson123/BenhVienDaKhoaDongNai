namespace Data_eHospital_DongNai_A_NSTL.Model
{
    public partial class NS_L_CHITIEU_NV : BaseModel
    {
        [Key]
        public int? ID { get; set; }
public string? Nam { get; set; }
public string? Thang { get; set; }
public string? MaNhanVien { get; set; }
public string? MaChiTieu { get; set; }
public string? CongThuc { get; set; }
public float? GiaTri { get; set; }

        public NS_L_CHITIEU_NV()
        {
        }
    }
}

