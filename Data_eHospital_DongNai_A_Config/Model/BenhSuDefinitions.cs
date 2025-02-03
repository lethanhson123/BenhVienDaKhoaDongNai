namespace Data_eHospital_DongNai_A_Config.Model
{
    public partial class BenhSuDefinitions : BaseModel
    {
        [Key]
        public int? BenhSuDefinition_Id { get; set; }
public string? BenhSuDefinition_Code { get; set; }
public string? BenhSuDefinition_Name { get; set; }
public string? BenhSuDefinition_Name_En { get; set; }
public string? BenhSuDefinition_Name_Ru { get; set; }
public int? Parent_Id { get; set; }
public bool? CallAnotherForm { get; set; }
public int? Menu_Id { get; set; }
public int? Report_Id { get; set; }
public string? ReportKey_Name { get; set; }
public int? ZoomPercents { get; set; }
public bool? Enabled { get; set; }
public bool? IsCrossTab { get; set; }
public string? ReportTableIndex { get; set; }
public string? ColumnNameItem { get; set; }
public string? ColumnValueItem { get; set; }
public string? Description { get; set; }

        public BenhSuDefinitions()
        {
        }
    }
}

