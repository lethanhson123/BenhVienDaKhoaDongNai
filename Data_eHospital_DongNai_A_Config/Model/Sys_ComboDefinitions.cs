namespace Data_eHospital_DongNai_A_Config.Model
{
    public partial class Sys_ComboDefinitions : BaseModel
    {
        [Key]
        public int? ComboDefinition_Id { get; set; }
public string? ComboDefinition_Code { get; set; }
public string? Language_Id { get; set; }
public string? Description { get; set; }
public string? ColumnHeader { get; set; }
public bool? AddBlankItem { get; set; }
public bool? ColumnHeaderVisible { get; set; }
public string? ProcedureName { get; set; }
public string? DefaultValue { get; set; }
public string? DefaultValueName { get; set; }
public bool? UseDefaultSort { get; set; }
public bool? LovEnabled { get; set; }
public string? Attribute1 { get; set; }
public string? Attribute2 { get; set; }
public string? Attribute3 { get; set; }
public string? Attribute4 { get; set; }
public string? Attribute5 { get; set; }

        public Sys_ComboDefinitions()
        {
        }
    }
}

