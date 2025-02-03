namespace Data_eHospital_DongNai_A_Config.Model
{
    public partial class Sys_Configs : BaseModel
    {
        [Key]
        public int? Config_Id { get; set; }
public string? Config_Code { get; set; }
public string? Language_Id { get; set; }
public string? Config_Type { get; set; }
public string? Config_Data { get; set; }
public string? Description { get; set; }
public string? Table_Name { get; set; }
public int? Idx { get; set; }
public int? Parent_Id { get; set; }
public int? User_Id { get; set; }
public int? Group_Id { get; set; }
public string? Attribute1 { get; set; }
public string? Attribute2 { get; set; }
public string? Attribute3 { get; set; }

        public Sys_Configs()
        {
        }
    }
}

