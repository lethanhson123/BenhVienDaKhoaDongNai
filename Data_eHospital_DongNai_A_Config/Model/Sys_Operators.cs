namespace Data_eHospital_DongNai_A_Config.Model
{
    public partial class Sys_Operators : BaseModel
    {
        [Key]
        public int? Operator_Id { get; set; }
public string? GroupCode { get; set; }
public string? OperatorCode { get; set; }
public string? Language_Id { get; set; }
public string? OperatorName { get; set; }
public int? Idx { get; set; }
public string? SetDefaultForSystemType { get; set; }
public string? ApplyForSystemType { get; set; }
public string? Description { get; set; }
public bool? Enabled { get; set; }

        public Sys_Operators()
        {
        }
    }
}

