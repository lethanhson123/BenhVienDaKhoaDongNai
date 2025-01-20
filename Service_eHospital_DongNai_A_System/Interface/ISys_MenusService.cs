namespace Service_eHospital_DongNai_A_System.Interface
{
    public interface ISys_MenusService : IBaseService<Sys_Menus>
    {
        Task<List<Sys_Menus>> GetByMenu_LevelToListAsync(int Menu_Level);
        Task<List<Sys_Menus>> GetByParent_IdToListAsync(int Parent_Id);
        Task<List<Sys_Menus>> GetByParent_IdAndEmptyToListAsync(int Parent_Id);
    }
}

