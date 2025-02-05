namespace Data_eHospital_DongNai_A_NSTL.Model
{
    public partial class NS_PHEPNAM : BaseModel
    {
        [Key]
        public string? MaNhanVien { get; set; }
public int? Nam { get; set; }
public int? NgayPhep { get; set; }
public float? T1 { get; set; }
public float? T2 { get; set; }
public float? T3 { get; set; }
public float? T4 { get; set; }
public float? T5 { get; set; }
public float? T6 { get; set; }
public float? T7 { get; set; }
public float? T8 { get; set; }
public float? T9 { get; set; }
public float? T10 { get; set; }
public float? T11 { get; set; }
public float? T12 { get; set; }
public float? TraLuong { get; set; }
public float? PhepDu { get; set; }
public DateTime? Du1 { get; set; }
public DateTime? Du2 { get; set; }
public string? Du3 { get; set; }
public string? Du4 { get; set; }
public string? Du5 { get; set; }
public float? PhepNamCu { get; set; }
public float? PhepNamNay { get; set; }
public int? PhepThamNien { get; set; }

        public NS_PHEPNAM()
        {
        }
    }
}

