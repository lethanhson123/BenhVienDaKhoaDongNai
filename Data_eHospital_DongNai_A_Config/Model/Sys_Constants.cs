namespace Data_eHospital_DongNai_A_Config.Model
{
    public partial class Sys_Constants : BaseModel
    {
        [Key]
        public int? Const_Id { get; set; }
public string? Const_Group_Parent { get; set; }
public string? Const_Group { get; set; }
public string? Const_Code { get; set; }
public string? Const_Value { get; set; }
public string? Const_Value_1 { get; set; }
public string? Const_Value_2 { get; set; }
public string? Const_Value_3 { get; set; }
public string? Description { get; set; }
public string? Const_Value_Default { get; set; }
public string? Const_Value_Default_1 { get; set; }
public string? Const_Value_Default_2 { get; set; }
public string? Const_Value_Default_3 { get; set; }
public string? Change_Log { get; set; }

        public Sys_Constants()
        {
        }
    }
}

