namespace Data_eHospital_DongNai_A_Config.Model
{
    public partial class Sys_AppPrivateSettingItems : BaseModel
    {
        [Key]
        public int? Setting_Id { get; set; }
public string? SettingCode { get; set; }
public string? SettingName { get; set; }
public string? ControlName { get; set; }

        public Sys_AppPrivateSettingItems()
        {
        }
    }
}

