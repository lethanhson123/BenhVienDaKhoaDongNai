namespace Service_eHospital_DongNai_A_System.Interface
{
    public interface ISys_UserGroupsService : IBaseService<Sys_UserGroups>
    {
        Task<List<Sys_UserGroups>> GetByUser_Id_SearchStringToListAsync(int User_Id, string searchString);
        Task<List<Sys_UserGroups>> GetByUser_Id_SearchStringAndEmptyToListAsync(int User_Id, string searchString);
        Task<List<Sys_UserGroups>> GetByUser_IdToListAsync(int User_Id);
        Task<List<Sys_UserGroups>> GetByUser_IdAndEmptyToListAsync(int User_Id);
    }
}

