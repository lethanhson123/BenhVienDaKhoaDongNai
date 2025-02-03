namespace Data_eHospital_DongNai_A_Config.Model
{
    public partial class Sys_LovDefinitions : BaseModel
    {
        [Key]
        public int? LovDefinition_Id { get; set; }
public string? DataGroup { get; set; }
public string? Language_Id { get; set; }
public string? FormName { get; set; }
public string? ControlName { get; set; }
public string? OtherKey { get; set; }
public string? ProcedureName { get; set; }
public bool? Enabled { get; set; }
public bool? AllowMultiResult { get; set; }
public bool? LostFocusIfOK { get; set; }
public string? ControlNameDesc { get; set; }
public string? ColumnHeader { get; set; }
public bool? ColumnHeaderVisible { get; set; }
public string? Description { get; set; }
public bool? UseDefaultSort { get; set; }
public bool? LovUseSystemFunction { get; set; }
public bool? AllowFilterData { get; set; }
public bool? AllowGroupData { get; set; }
public string? DefaultFilterColumn { get; set; }
public string? Attribute1 { get; set; }
public string? Attribute2 { get; set; }
public string? Attribute3 { get; set; }
public string? Attribute4 { get; set; }
public string? Attribute5 { get; set; }

        public Sys_LovDefinitions()
        {
        }
    }
}

