namespace Data_eHospital_DongNai_A_NSTL.Model
{
    public partial class NS_RP_DSField : BaseModel
    {
        [Key]
        public string? Ma { get; set; }
public string? Ten { get; set; }
public string? Viet { get; set; }
public int? Loai { get; set; }
public string? BangQH { get; set; }
public string? TenTable { get; set; }
public int? SapXep { get; set; }

        public NS_RP_DSField()
        {
        }
    }
}

