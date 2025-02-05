namespace Data_eHospital_DongNai_A_NSTL.Model
{
    public partial class NS_RP_LSTREPORT : BaseModel
    {
        [Key]
        public string? REPORTCODE { get; set; }
public string? REPORTTITLE { get; set; }
public string? REPORTFILENAME { get; set; }
public string? PACKAGENAME { get; set; }
public string? PROCEDURENAME { get; set; }
public string? PACKAGENAME_ORIGIN_DATA { get; set; }
public string? TableMapping { get; set; }
public string? REPORTTYPE { get; set; }
public int? Sort { get; set; }

        public NS_RP_LSTREPORT()
        {
        }
    }
}

