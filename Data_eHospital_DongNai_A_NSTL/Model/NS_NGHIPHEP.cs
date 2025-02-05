namespace Data_eHospital_DongNai_A_NSTL.Model
{
    public partial class NS_NGHIPHEP : BaseModel
    {
        [Key]
        public int? ID { get; set; }
public string? MaNhanVien { get; set; }
public DateTime? TuNgay { get; set; }
public DateTime? DenNgay { get; set; }
public string? MaLydoNghiphep { get; set; }

        public NS_NGHIPHEP()
        {
        }
    }
}

