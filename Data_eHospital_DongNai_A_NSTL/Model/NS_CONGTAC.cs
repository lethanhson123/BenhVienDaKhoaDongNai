namespace Data_eHospital_DongNai_A_NSTL.Model
{
    public partial class NS_CONGTAC : BaseModel
    {
        [Key]
        public int? ID { get; set; }
public string? MaNhanVien { get; set; }
public string? Congty { get; set; }
public DateTime? Tungay { get; set; }
public DateTime? DenNgay { get; set; }
public string? Phongban { get; set; }
public string? ToNhom { get; set; }
public string? Chucvu { get; set; }
public string? Congviec { get; set; }

        public NS_CONGTAC()
        {
        }
    }
}

