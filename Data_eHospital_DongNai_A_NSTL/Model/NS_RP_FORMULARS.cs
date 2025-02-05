namespace Data_eHospital_DongNai_A_NSTL.Model
{
    public partial class NS_RP_FORMULARS : BaseModel
    {
        [Key]
        public int? ID { get; set; }
public string? REPORTCODE { get; set; }
public string? NAME { get; set; }
public string? CONTROLNAME { get; set; }
public string? VALUE { get; set; }

        public NS_RP_FORMULARS()
        {
        }
    }
}

