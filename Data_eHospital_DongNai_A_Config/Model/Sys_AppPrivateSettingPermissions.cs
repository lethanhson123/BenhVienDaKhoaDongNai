namespace Data_eHospital_DongNai_A_Config.Model
{
    public partial class Sys_AppPrivateSettingPermissions : BaseModel
    {
        [Key]
        public int? SettingPermission_Id { get; set; }
public int? Setting_Id { get; set; }
public int? User_Id { get; set; }
public int? Group_Id { get; set; }
public bool? EditRight { get; set; }
public bool? DeleteRight { get; set; }

        public Sys_AppPrivateSettingPermissions()
        {
        }
    }
}

