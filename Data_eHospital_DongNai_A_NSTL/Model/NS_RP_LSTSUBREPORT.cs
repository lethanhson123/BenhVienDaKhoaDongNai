namespace Data_eHospital_DongNai_A_NSTL.Model
{
    public partial class NS_RP_LSTSUBREPORT : BaseModel
    {
        [Key]
        public string? REPORTCODE { get; set; }
public float? IDX { get; set; }
public string? REPORTFILENAME { get; set; }
public string? PROCEDURENAME { get; set; }
public string? TableMapping { get; set; }

        public NS_RP_LSTSUBREPORT()
        {
        }
    }
}

