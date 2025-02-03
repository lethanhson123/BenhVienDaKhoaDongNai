namespace Data_eHospital_DongNai_A_Config.Model
{
    public partial class Sys_HistoryDefines : BaseModel
    {
        [Key]
        public int? HistoryDefine_Id { get; set; }
public string? DataGroup { get; set; }
public string? TableName { get; set; }
public bool? Insert_Enabled { get; set; }
public bool? Update_Enabled { get; set; }
public bool? Delete_Enabled { get; set; }
public string? Description { get; set; }

        public Sys_HistoryDefines()
        {
        }
    }
}

