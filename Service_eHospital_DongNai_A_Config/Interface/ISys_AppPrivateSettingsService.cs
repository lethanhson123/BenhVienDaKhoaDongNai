namespace Service_eHospital_DongNai_A_Config.Interface
{
    public interface ISys_AppPrivateSettingsService : IBaseService<Sys_AppPrivateSettings>
    {
        Task<List<Sys_AppPrivateSettings>> GetByUser_IdAndEmptyToListAsync(int User_Id);
        Task<List<Sys_AppPrivateSettings>> GetByUser_IdAndCodeAndEmptyToListAsync(int User_Id, string Code);
    }
}

