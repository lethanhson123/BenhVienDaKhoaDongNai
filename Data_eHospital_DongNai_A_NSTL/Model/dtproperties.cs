namespace Data_eHospital_DongNai_A_NSTL.Model
{
    public partial class dtproperties : BaseModel
    {
        [Key]
        public int? id { get; set; }
public int? objectid { get; set; }
public string? property { get; set; }
public string? value { get; set; }
public string? uvalue { get; set; }
public string? lvalue { get; set; }
public int? version { get; set; }

        public dtproperties()
        {
        }
    }
}

