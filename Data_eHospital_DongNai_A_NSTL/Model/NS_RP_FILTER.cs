namespace Data_eHospital_DongNai_A_NSTL.Model
{
    public partial class NS_RP_FILTER : BaseModel
    {
        [Key]
        public int? ID { get; set; }
public string? REPORTCODE { get; set; }
public float? IDX { get; set; }
public string? FILTER { get; set; }
public string? DEFAULTVALUE { get; set; }
public bool? ISNOTNULL { get; set; }

        public NS_RP_FILTER()
        {
        }
    }
}

