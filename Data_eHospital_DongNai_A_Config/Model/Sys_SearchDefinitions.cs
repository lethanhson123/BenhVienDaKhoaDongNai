namespace Data_eHospital_DongNai_A_Config.Model
{
    public partial class Sys_SearchDefinitions : BaseModel
    {
        [Key]
        public string? ID { get; set; }
public string? DataGroup { get; set; }
public string? DataGroup_Name { get; set; }
public string? FieldName { get; set; }
public string? AlternateFieldName { get; set; }
public string? Description { get; set; }
public int? Idx { get; set; }
public string? DataType { get; set; }
public string? Remark { get; set; }
public bool? Enabled { get; set; }
public bool? IsSearch { get; set; }

        public Sys_SearchDefinitions()
        {
        }
    }
}

