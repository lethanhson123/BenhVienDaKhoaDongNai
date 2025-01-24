namespace Data_eHospital_DongNai_A.Model
{
    public partial class sysdiagrams : BaseModel
    {
        [Key]
        public string? name { get; set; }
public int? principal_id { get; set; }
public int? diagram_id { get; set; }
public int? version { get; set; }
public string? definition { get; set; }

        public sysdiagrams()
        {
        }
    }
}

