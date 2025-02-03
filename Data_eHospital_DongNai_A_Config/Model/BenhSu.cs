namespace Data_eHospital_DongNai_A_Config.Model
{
    public partial class BenhSu : BaseModel
    {
        [Key]
        public int? Cap { get; set; }
public string? Ma { get; set; }
public string? MaCapTren { get; set; }
public string? Ten { get; set; }
public string? TenPhu { get; set; }
public string? aspx { get; set; }

        public BenhSu()
        {
        }
    }
}

