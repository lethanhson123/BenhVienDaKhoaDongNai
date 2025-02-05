namespace Data_eHospital_DongNai_A_NSTL.Model
{
    public partial class NS_NGOAINGU_UV : BaseModel
    {
        [Key]
        public int? id { get; set; }
public string? MaUngVien { get; set; }
public string? MaTDNgoaiNgu { get; set; }
public string? Trinhdo { get; set; }
public string? Nghe { get; set; }
public string? Noi { get; set; }
public string? Doc { get; set; }
public string? Viet { get; set; }

        public NS_NGOAINGU_UV()
        {
        }
    }
}

